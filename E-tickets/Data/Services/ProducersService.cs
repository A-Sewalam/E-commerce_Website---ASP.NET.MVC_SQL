using E_tickets.Data.Base;
using E_tickets.Models;

namespace E_tickets.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
            
        }
    }
}
