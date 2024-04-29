using Microsoft.AspNetCore.Mvc;

namespace ProjectIntake.Controllers
{
    public class AccountController : Controller
    {

      
        public IActionResult CreateAccount()
        {
            return View();
        }

        public IActionResult AccountLogin()
        {
            return View();
        }
        public IActionResult ClientLogin()
        {
            return View();
        }
        public IActionResult AdminLogin()
        {
            return View();
        }
        public IActionResult ClientCreateAccount()
        {
            return View();
        }
    }
}
