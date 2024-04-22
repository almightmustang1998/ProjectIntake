using Microsoft.AspNetCore.Mvc;

namespace ProjectIntake.Controllers
{
    public class ViewProjectController : Controller
    {
        public IActionResult ViewProject()
        {
            return View("~/Views/Admin/Project/ViewProject.cshtml");

        }
    }
}
