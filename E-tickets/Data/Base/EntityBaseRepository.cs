
using E_tickets.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace E_tickets.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {

        private readonly AppDbContext _context;

        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }


        // Explanation for the 4 functions
        public async Task AddAsync(T entity) { 
            await _context.Set<T>().AddAsync(entity); // how it's working , with the same name?
            await _context.SaveChangesAsync(); 
        }
        

        //public async Task  AddAsync(T entity)
        //{
        //    await _context.Set<T>().AddAsync(entity);
        //}

    

        public async Task<IEnumerable<T>> GetallAsync() => await _context.Set<T>().ToListAsync();




        //public async Task<IEnumerable<T>> GetallAsync()
        //{
        //    var result = await _context.Set<T>().ToListAsync(); // why not just t what is set 
        //    return result;
        //}

        

        public async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);



        //public async Task<T> GetByIdAsync(int id)
        //{
        //    var result = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
        //    return result;
        //}

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();

        }




    }
}
