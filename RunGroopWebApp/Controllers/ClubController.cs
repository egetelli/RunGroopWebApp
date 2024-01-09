using Microsoft.AspNetCore.Mvc;
using RunGroopWebApp.Data;

namespace RunGroopWebApp.Controllers
{
    public class ClubController : Controller
    {
        public ClubController(ApplicationDbContext context)
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
