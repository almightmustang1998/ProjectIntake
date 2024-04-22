using Microsoft.AspNetCore.Mvc;

namespace ProjectIntake.Controllers
{
    public class ClientViewProjectDetailsController : Controller
    {
        public IActionResult ClientViewProjectDetails()
        {
            return View("~/Views/Client/Project/ClientViewProjectDetails.cshtml");
        }
    }
}
