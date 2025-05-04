using E_tickets.Data;
using E_tickets.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_tickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service ) // how we pass AppDbContext
        {
            _service = service;
        }
        public async Task <IActionResult> Index()
        {
            var data = await _service.Getall(); 
            //var data = _context.Actors.ToList();// transfare data in db in list to deal with

            return View(data);
        }

        public async Task <IActionResult> create()
        {
            return View();
        }
    }
}
