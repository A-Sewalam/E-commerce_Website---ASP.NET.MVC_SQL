using E_tickets.Models;
using System.Linq.Expressions;

namespace E_tickets.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {

        Task<IEnumerable<T>> GetallAsync();
        Task<IEnumerable<T>> GetallAsync(params Expression<Func<T, object>>[] includeProperties); // needs clarification

        Task<T> GetByIdAsync(int Id);

        Task AddAsync(T entity);

        Task UpdateAsync(int id, T entity);

        // it was Task<T> what is the diffrence 
        Task DeleteAsync(int id);

    }
}
