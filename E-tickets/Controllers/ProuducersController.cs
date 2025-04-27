using E_tickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_tickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<IActionResult> Indexs()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View();
        }
    }
}
