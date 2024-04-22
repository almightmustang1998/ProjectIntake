using Microsoft.AspNetCore.Mvc;
using ProjectIntake.Models;

namespace ProjectIntake.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {

            return View("~/Views/Admin/Main/Dashboard.cshtml");
        }
    }
}
