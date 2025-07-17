using E_tickets.Data.Base;
using E_tickets.Models;

namespace E_tickets.Data.Services
{
   
        public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
        {
            public CinemasService(AppDbContext context) : base(context)
            {
            }
        }
    
}
