using E_tickets.Data;
using E_tickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_tickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController( IMoviesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.GetallAsync(n => n.Cinema);
            return View(allMovies);
        }

        //GET: Movies/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetMovieByIdAsync(id);
            return View(movieDetail);
        }

        // Get : Movies/Create

        public IActionResult Create()
        {

            ViewData["Welcome"] = "Welcome to our Stroe";
            ViewBag.Description = "hello";
            return View();
        }

    }
}
