using Microsoft.AspNetCore.Mvc;

namespace ProjectIntake.Controllers
{
    public class ViewProfileController : Controller
    {
        public IActionResult ViewProfile()
        {
            return View("~/Views/Admin/Profile/ViewProfile.cshtml");

        }
    }
}
