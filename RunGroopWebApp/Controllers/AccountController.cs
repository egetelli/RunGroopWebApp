using Microsoft.AspNetCore.Mvc;

namespace RunGroopWebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM login)
        {

        }
    }
}
