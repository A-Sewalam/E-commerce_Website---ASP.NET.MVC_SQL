using E_tickets.Models;

namespace E_tickets.Data.Services
{
    public interface IActorsService
    {

        Task<IEnumerable<Actor>> Getall();
        Actor GetbyId(int Id);
        void Add(Actor actor);

        Actor Update(int id, Actor newActor);

        void Delete(int id);

    }
}
