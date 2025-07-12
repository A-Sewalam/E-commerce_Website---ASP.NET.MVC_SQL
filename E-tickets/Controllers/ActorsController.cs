using E_tickets.Data;
using E_tickets.Data.Services;
using E_tickets.Models;
using Microsoft.AspNetCore.Mvc;


namespace E_Tickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetallAsync();
            return View(data);
        }

        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,PictureProfileURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }


        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind(" Id,FullName,PictureProfileURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id); // check the actor 

            if (actorDetails == null) return View("NotFound"); // if not found

            return View(actorDetails); // if found dispaly him
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id); // check the actor 

            if (actorDetails == null) return View("NotFound"); // if not found

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //public IActionResult DeleteConfirmed(int id)
        //{
        //    var actorDetails = _service.GetById(id); // synchronous version

        //    if (actorDetails == null)
        //    {
        //        return View("NotFound"); // if not found
        //    }

        //    _service.Delete(id); // synchronous delete
        //    return RedirectToAction(nameof(Index));
        //}


    }
}