using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Souqna.Data;
using Souqna.Data.Repositories;

namespace Souqna.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminOrdersController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public AdminOrdersController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            // جلب جميع الطلبات (لأن الدور Admin)
            var orders = await _unitOfWork.Orders.GetOrdersByUserIdAndRoleAsync("", "Admin");
            return View(orders);
        }
        // 📌 تفاصيل طلب
        public async Task<IActionResult> Details(Guid id)//يجلب تفاصيل طلب معين
        {
            var orders = await _unitOfWork.Orders.GetOrdersByUserIdAndRoleAsync("", "Admin");
            var order = orders.FirstOrDefault(o => o.OrderId == id);

            if (order == null)
                return NotFound();

            return View(order);
        }

        // 📌 حذف طلب (عرض تأكيد الحذف)
        public async Task<IActionResult> Delete(Guid id)//يجلب طلب معين للحذف
        {
            var orders = await _unitOfWork.Orders.GetOrdersByUserIdAndRoleAsync("", "Admin");
            var order = orders.FirstOrDefault(o => o.OrderId == id);

            if (order == null)
                return NotFound();

            return View(order);
        }

        // 📌 تنفيذ الحذف
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)// تنفيذ حذف الطلب
        {
            await _unitOfWork.Orders.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }


}

