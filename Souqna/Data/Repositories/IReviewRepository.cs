using Souqna.Models;

namespace Souqna.Data.Repositories
{
    public interface IReviewRepository
    {
        Task<IEnumerable<Review>> GetAllAsync();                 // جلب كل الآراء
        Task<Review?> GetByIdAsync(int id);                      // جلب رأي حسب المعرف
        Task AddAsync(Review review);                            // إضافة رأي جديد
        Task UpdateAsync(Review review);                         // تحديث رأي
        Task DeleteAsync(int id);                                // حذف رأي
        Task<IEnumerable<Review>> GetApprovedReviewsAsync(int count = 6); // جلب الآراء المقبولة
    }
}
