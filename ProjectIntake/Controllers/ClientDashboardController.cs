using Microsoft.AspNetCore.Mvc;

namespace ProjectIntake.Controllers
{
    public class ClientDashboardController : Controller
    {
        public IActionResult ClientDashboard()
        {
            return View("~/Views/Client/Main/ClientDashboard.cshtml");

        }
    }
}
