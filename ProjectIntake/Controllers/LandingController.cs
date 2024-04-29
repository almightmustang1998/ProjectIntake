using Microsoft.AspNetCore.Mvc;

namespace ProjectIntake.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
