using Microsoft.AspNetCore.Mvc;
using Web1.Models;

namespace Web1.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Car1()
        {
            var c= new Car();
            c.Brand = "Ford";
            c.Name = "Mokka";
            c.Id = 1;
            return View("CarDetail",c);
        }
        public IActionResult Car2()
        {
            var c = new Car();
            c.Brand = "Audi";
            c.Name = "R8";
            c.Id = 2;
            return View("CarDetail",c);
        }


    }
}
