using Microsoft.AspNetCore.Mvc;
using Web1.Models;

namespace Web1.Controllers
{
    public class DersController : Controller
    {
        public IActionResult Index()
        {
            var list = MockData.Courses.ToList();
            list[1].Attenders.AddRange(MockData.Users.Take(3).ToList());
            return View(list);
        }

        public IActionResult Details(int id)
        {
            var c = MockData.Courses.FirstOrDefault(x => x.Id == id);
            return View(c);
        }



    }
}
