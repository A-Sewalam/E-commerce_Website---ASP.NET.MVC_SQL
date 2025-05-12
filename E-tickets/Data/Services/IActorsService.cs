using E_tickets.Models;

namespace E_tickets.Data.Services
{
    public interface IActorsService
    {

        Task<IEnumerable<Actor>> GetallAsync();

        Task <Actor> GetByIdAsync(int Id);

        Task AddAsync(Actor actor);

        Task <Actor> UpdateAsync(int id, Actor newActor);

        Task DeleteAsync(int id);
        
    }
}
