using Microsoft.AspNetCore.Mvc;

namespace ProjectIntake.Controllers
{
    public class ManageProfilesController : Controller
    {
        public IActionResult ManageProfiles ()
        {
            return View("~/Views/Admin/Profile/ManageProfiles.cshtml");
        }
    }
}
