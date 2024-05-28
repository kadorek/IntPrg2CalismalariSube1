using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fihrist.Areas.Manegement.Controllers
{
    [Area("Manegement")]
    public class DemoController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Ali() {
            return View();
        }

        [Authorize]
        public IActionResult Mehmet() {
            return View();
        }


        [Authorize]
        public IActionResult Adem() {
            return View();
        }


    }
}
