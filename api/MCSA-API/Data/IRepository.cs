namespace MCSA_API.Data;

public interface IRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<bool> TryGetByIdAsync(int id, out T entity);
    Task<IEnumerable<T>> GetAllAsync();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
}