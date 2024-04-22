using Microsoft.AspNetCore.Mvc;

namespace ProjectIntake.Controllers
{
    public class ClientViewProjectsController : Controller
    {
        public IActionResult ClientViewProjects()
        {
            return View("~/Views/Client/Project/ClientViewProjects.cshtml");
        }
    }
}
