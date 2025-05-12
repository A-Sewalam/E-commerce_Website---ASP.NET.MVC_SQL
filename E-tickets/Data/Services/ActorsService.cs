using E_tickets.Models;
using Microsoft.EntityFrameworkCore;

namespace E_tickets.Data.Services
{
    public class ActorsService : IActorsService
    {

        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Actor actor)
        {
          await   _context.Actors.AddAsync(actor);
          await  _context.SaveChangesAsync(); 
        }

        public async Task  DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id); //lget the actor 

             _context.Actors.Remove(result); // no await here the process done non-premptive

            await _context.SaveChangesAsync();


        }



        public async Task<IEnumerable<Actor>> GetallAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

      

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n=> n.Id == id);
                return result;
        }

        public async Task <Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;

        }
    }
}
