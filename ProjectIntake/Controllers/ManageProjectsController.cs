using Microsoft.AspNetCore.Mvc;

namespace ProjectIntake.Controllers
{
    public class ManageProjectsController : Controller
    {
        public IActionResult ManageProjects()
        {
            return View("~/Views/Admin/Project/ManageProjects.cshtml");
        }
    }
}
