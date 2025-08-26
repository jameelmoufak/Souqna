using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Souqna.Data.Repositories;
using Souqna.Services.Notifications; // عشان نستخدم الإشعارات

namespace Souqna.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminProductsController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly INotificationService _notificationService;

        public AdminProductsController(UnitOfWork unitOfWork, INotificationService notificationService)
        {
            _unitOfWork = unitOfWork;
            _notificationService = notificationService;
        }

        // 📌 المنتجات التي بانتظار الموافقة
        public async Task<IActionResult> PendingProducts()
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            var pending = products.Where(p => !p.IsApproved).ToList();
            return View(pending);
        }

        // 📌 الموافقة على منتج
        public async Task<IActionResult> Approve(Guid id)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(id);
            if (product == null) return NotFound();

            product.IsApproved = true;
            _unitOfWork.Products.Update(product);
            await _unitOfWork.SaveAsync();

            // إشعار للمستخدم
            await _notificationService.NotifyUserAsync(
                product.UserId,
                $"✅ تمت الموافقة على منتجك: {product.Name}",
                Url.Action("Details", "Product", new { id = product.ProductId })
            );

            TempData["Success"] = "تمت الموافقة على المنتج بنجاح ✅";
            return RedirectToAction(nameof(PendingProducts));
        }

        // 📌 رفض منتج (حذفه مثلاً)
        public async Task<IActionResult> Reject(Guid id)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(id);
            if (product == null) return NotFound();

            await _unitOfWork.Products.DeleteAsync(id);

            // إشعار للمستخدم
            await _notificationService.NotifyUserAsync(product.UserId, $"❌ تم رفض منتجك: {product.Name}");

            TempData["Error"] = "تم رفض المنتج ❌";
            return RedirectToAction(nameof(PendingProducts));
        }
    }
}
