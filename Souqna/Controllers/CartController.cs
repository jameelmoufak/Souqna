using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Souqna.Data;
using Souqna.Data.Cart;
using Souqna.Data.ViewModels;
using Souqna.Models;
using System.Security.Claims;

namespace Souqna.Controllers
{
    public class CartController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        private readonly ShoppingCart _shoppingCart;
        private readonly ApplicationDbContext context;

        public CartController(UserManager<ApplicationUser> userManager ,ShoppingCart shoppingCart, ApplicationDbContext context)
        {
            this.userManager = userManager;

            _shoppingCart = shoppingCart;
            this.context = context;

        }

        // يرجع العدد في Json (عشان نستخدمه في الـ badge)
        public IActionResult CartCount()
        {
            var count = _shoppingCart.GetShoppingCartCount();
            return Json(count);
        }

        // صفحة السلة نفسها
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            return View(items);
        }
        public async Task<IActionResult> MyAccount()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var vm = new MyAccountVM
            {
                // 🛒 المنتجات في السلة
                CartItems = await context.ShoppingCartItems
                    .Include(c => c.Product)
                    .Where(c => c.ShoppingCartId == _shoppingCart.ShoppingCartId)
                    .ToListAsync(),

                // ✅ المنتجات التي اشتراها المستخدم
                PurchasedProducts = await context.OrderItems
                    .Include(oi => oi.product)
                    .Where(oi => oi.order.UserId == userId)
                    .ToListAsync(),


                // 🏷️ المنتجات المعروضة للبيع
                SoldProducts = await context.Products
                    .Where(p => p.UserId == userId)
                    .OrderBy(p => p.Name) // ✅ OrderBy
                    .ToListAsync()
            };

            return View(vm);
        }

        public async Task<IActionResult> CartInfo()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var purchasedCount = await context.OrderItems
                .Include(oi => oi.order)
                .Where(oi => oi.order.UserId == userId)
                .CountAsync();

            var soldCount = await context.Products
                .Where(p => p.UserId == userId)
                .CountAsync();

            // إذا أردت جلب المنتجات المباعة مع ترتيب
            var soldProducts = await context.Products
                .Where(p => p.UserId == userId)
                .OrderBy(p => p.Name) // ترتيب بالاسم كمثال
                .ToListAsync();

            return Json(new { purchased = purchasedCount, sold = soldCount, soldProducts });
        }





    }
}
