using E_tickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace E_tickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context) // how we pass AppDbContext
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Actors.ToList();// transfare data in db in list to deal with

            return View(data);
        }
    }
}
