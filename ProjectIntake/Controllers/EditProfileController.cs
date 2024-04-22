using Microsoft.AspNetCore.Mvc;

namespace ProjectIntake.Controllers
{
    public class EditProfileController : Controller
    {
        public IActionResult EditProfile()
        {
            return View("~/Views/Client/Profile/EditProfile.cshtml");
        }
    }
}
