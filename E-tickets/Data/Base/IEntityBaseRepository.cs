using E_tickets.Models;

namespace E_tickets.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class , IEntityBase , new()
    {
        Task<IEnumerable<T>> GetallAsync();

        Task<T> GetByIdAsync(int Id);

        Task AddAsync(T entity);

        Task UpdateAsync(int id, T entity);

        // it was Task<T> what is the diffrence 
        Task DeleteAsync(int id);

    }
}
