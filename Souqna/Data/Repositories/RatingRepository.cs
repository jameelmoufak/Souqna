using Microsoft.EntityFrameworkCore;
using Souqna.Models;

namespace Souqna.Data.Repositories
{
    public class RatingRepository : IRatingRepository
    {
        private readonly ApplicationDbContext _context;

        public RatingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddOrUpdateAsync(Rating rating)
        {
            var existing = await _context.Ratings
                .FirstOrDefaultAsync(r => r.ProductId == rating.ProductId && r.UserId == rating.UserId);

            if (existing != null)
            {
                existing.Stars = rating.Stars; // تحديث التقييم
                _context.Ratings.Update(existing);
            }
            else
            {
                await _context.Ratings.AddAsync(rating);
            }

            await _context.SaveChangesAsync();
        }

        public async Task<double> GetAverageRatingAsync(Guid productId)
        {
            return await _context.Ratings
                .Where(r => r.ProductId == productId)
                .AverageAsync(r => (double?)r.Stars) ?? 0;
        }

        public async Task<int> GetUserRatingAsync(Guid productId, string userId)
        {
            var rating = await _context.Ratings
                .FirstOrDefaultAsync(r => r.ProductId == productId && r.UserId == userId);

            return rating?.Stars ?? 0;
        }
    }
}
