using Microsoft.EntityFrameworkCore;

namespace Souqna.Data.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        public readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<T> AddAsync(T entity)
        {
            var newEntity = await context.AddAsync(entity);
            await context.SaveChangesAsync();
            return newEntity.Entity;
        }

        public async Task<T>? GetByIdAsync(Guid id)
        {
            return await context.FindAsync<T>(id);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }
        public T Update(T entity)
        {
            var UpdatedEntity = context.Update(entity).Entity;
            context.SaveChanges();
            return UpdatedEntity;
        }
        public async Task DeleteAsync(Guid id)
        {
            var entity = await context.FindAsync<T>(id);
            if (entity != null)
            {
                context.Remove(entity);
                await context.SaveChangesAsync();
            }
        }

    }
}
