namespace Souqna.Data.Repositories
{
    public interface IRepository<T>
    {
        Task<T> AddAsync(T entity);
        Task<T>? GetByIdAsync(Guid id);
        Task<List<T>> GetAllAsync();
        T Update(T entity);
        Task DeleteAsync(Guid id);
    }
}
