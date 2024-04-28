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
    }
}
