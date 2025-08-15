using Microsoft.AspNetCore.Mvc;

namespace E_tickets.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
