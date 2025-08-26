using Souqna.Models;

namespace Souqna.Data.Repositories
{
    public interface IRatingRepository
    {
        Task AddOrUpdateAsync(Rating rating);
        Task<double> GetAverageRatingAsync(Guid productId);
        Task<int> GetUserRatingAsync(Guid productId, string userId);
    }
}
