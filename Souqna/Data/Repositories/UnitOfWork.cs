using Souqna.Data.Services;
using Souqna.Models;

namespace Souqna.Data.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private readonly ApplicationDbContext _context;
        public IOrdersRepository Orders { get; }
        public IProductRepository Products { get; }
        public IStateRepository State { get; }
        public IReviewRepository Reviews { get; }
        public IRatingRepository Ratings { get; }


        public UnitOfWork(
            ApplicationDbContext context,
            IOrdersRepository orders,
            IProductRepository products,
            IStateRepository state,
             IReviewRepository reviews,
             IRatingRepository ratings)    
        {
            _context = context;
            Orders = orders;
            Products = products;
            State = state;
            Reviews = reviews;
            Ratings = ratings;
        }

        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}
