using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers {

    public class EmployeeController : Controller
    {
        public IActionResult Index1() {
            return View();
        }

        public ViewResult Index2() {
            return View("Index");
        }

        public IActionResult Index3() {
            return Content("Employee");
        }
     }
}