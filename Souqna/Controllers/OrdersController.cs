
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Souqna.Data.Cart;
using Souqna.Data.Repositories;
using Souqna.Data.Services;
using Souqna.Data.ViewModels;
using Souqna.Models;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;

using Souqna.Data.ViewModels;
using Souqna.Services.Notifications;


namespace Souqna.Controllers
{
    [Authorize] 
    public class OrdersController : Controller
    {
        private readonly IRepository<Product> repository;

        //private readonly IMoviesService _moviesService;
        private readonly ShoppingCart shoppingCart;
        private readonly IOrdersRepository ordersRepository;
        private readonly INotificationService _notificationService;
        public OrdersController(IRepository<Product> repository, ShoppingCart shoppingCart, IOrdersRepository ordersRepository, INotificationService notificationService)
        {
            this.repository = repository;
            //_moviesService = moviesService;
            this.shoppingCart = shoppingCart;
            this.ordersRepository = ordersRepository;
            _notificationService = notificationService;
        }

        public async Task<IActionResult> Index()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            string userRole = User.FindFirstValue(ClaimTypes.Role)!;

            var orders = await ordersRepository.GetOrdersByUserIdAndRoleAsync(userId, userRole);
            return View(orders);
        }

        public IActionResult ShoppingCart()
        {
            var items = shoppingCart.GetShoppingCartItems();
            shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartVM()
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = shoppingCart.GetShoppingCartTotal()
            };

            return View(response);
        }

        public async Task<IActionResult> AddItemToShoppingCart(Guid productId, int quantity)
        {
            var item = await repository.GetByIdAsync(productId);
            if (item != null)
            {
                if(item.StockQuantity > 0)
                {
                    shoppingCart.AddItemToCart(item, quantity);
                }
                else
                {
                    // Handle case where item is out of stock
                    TempData["ErrorMessage"] = "This item is out of stock.";
                }
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> RemoveItemFromShoppingCart(Guid productId, bool removeAll)
        {
            var item = await repository.GetByIdAsync(productId);
            if (item != null)
            {
                shoppingCart.RemoveItemFromCart(item, removeAll);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> CompleteOrder()
        {
            var items = shoppingCart.GetShoppingCartItems();
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;


            var buyerName = User.Identity?.Name; // 👈 هنا اسم المشتري

            //هل الرصيد يكفي للطلب
            //هل الكمية من المنتج كافية للطلب
            bool isAccepted = ordersRepository.CheckAccept(items, userId);
            if (!isAccepted)
            {
                TempData["ErrorMessage"] = "تعذر إكمال العملية! يرجى التحقق من رصيدك أو أن الكمية التي طلبتها من المنتج غير متاحة";
                return RedirectToAction(nameof(ShoppingCart));
            }
            await ordersRepository.StoreOrderAsync(items, userId);
            await shoppingCart.ClearShoppingCartAsync();


            // ✅ 2. إرسال إشعار لصاحب المنتج
            foreach (var item in items)
            {
                // صاحب المنتج
                var sellerId = item.Product.UserId;

                // لا ترسل إشعار لنفس المستخدم إذا هو يشتري منتجه
                if (sellerId != userId)
                {
                    await _notificationService.NotifyUserAsync(
                        sellerId,
                        $"🛒 {buyerName} قام بشراء منتجك: {item.Product.Name}",
                        Url.Action("Details", "Product", new { id = item.Product.ProductId })
                    );
                }
            }


            return View("OrderCompleted");
        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Checkout(Guid productId)
        {
            var product = await repository.GetByIdAsync(productId);
            if (product == null) return NotFound();

            var model = new CheckoutVM
            {
                ProductId = productId,
                Quantity = 1, // 👈 لازم تعطي قيمة ابتدائية للكمية
                EstimatedTotal = 1 * product.PriceOfUnit

            };

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Checkout(CheckoutVM model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = await ordersRepository.CheckoutAsync(model, userId);

            if (!response.IsSuccess)
            {
                TempData["Error"] = response.Message;
                return RedirectToAction("Checkout", new { productId = model.ProductId });
            }

            // ✅ إشعار لصاحب المنتج بعد إتمام الطلب بنجاح (مسار Checkout العادي)
            var product = await repository.GetByIdAsync(model.ProductId);
            var buyerName = User.Identity?.Name ?? "مستخدم";
            if (product.UserId != userId)
            {
                await _notificationService.NotifyUserAsync(
                    product.UserId,
                    $"🛒 {buyerName} قام بشراء منتجك: {product.Name} (الكمية: {model.Quantity})",
                    Url.Action("Details", "Product", new { id = product.ProductId })
                );
            }

            TempData["Success"] = response.Message;
            return RedirectToAction("Index", "Home");
        }

        //var product = await repository.GetByIdAsync(model.ProductId);
        //    if (product == null) return NotFound();
        //// 👈 هنا تستخدم model.Quantity مش quantity
        //model.EstimatedTotal = model.Quantity* product.PriceOfUnit;


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmPayPal([FromBody] PayPalCheckoutVM model)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            var checkoutModel = new CheckoutVM
            {
                ProductId = model.ProductId,
                Quantity = model.Quantity,
                PaymentMethod = "PayPal"
            };

            var response = await ordersRepository.CheckoutAsync(checkoutModel, userId);

            if (!response.IsSuccess)
                return Json(new { success = false, message = response.Message });

            // ✅ إشعار لصاحب المنتج بعد الدفع عبر PayPal
            var product = await repository.GetByIdAsync(model.ProductId);
            var buyerName = User.Identity?.Name ?? "مستخدم";
            if (product.UserId != userId)
            {
                await _notificationService.NotifyUserAsync(
                    product.UserId,
                    $"🛒 {buyerName} قام بشراء منتجك: {product.Name} (الكمية: {model.Quantity})",
                    Url.Action("Details", "Product", new { id = product.ProductId })
                );
            }


            return Json(new { success = true });
        }

    }
}
