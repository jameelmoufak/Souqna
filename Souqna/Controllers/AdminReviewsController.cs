using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Souqna.Data.Repositories;
using Souqna.Models;

namespace Souqna.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminReviewsController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public AdminReviewsController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // 📌 عرض جميع الآراء
        public async Task<IActionResult> Index()
        {
            var reviews = await _unitOfWork.Reviews.GetAllAsync();
            return View(reviews);
        }

        // 📌 الموافقة على رأي
        public async Task<IActionResult> Approve(int id)
        {
            var review = await _unitOfWork.Reviews.GetByIdAsync(id);
            if (review == null) return NotFound();

            review.IsApproved = true;
            await _unitOfWork.Reviews.UpdateAsync(review);

            return RedirectToAction(nameof(Index));
        }

        // 📌 حذف رأي
        public async Task<IActionResult> Delete(int id)
        {
            var review = await _unitOfWork.Reviews.GetByIdAsync(id);
            if (review == null) return NotFound();

            return View(review); // صفحة تأكيد الحذف
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _unitOfWork.Reviews.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
      

    }
}
