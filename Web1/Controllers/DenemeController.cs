using Microsoft.AspNetCore.Mvc;
using Web1.Models;

namespace Web1.Controllers
{
    public class DenemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult UserDetail()
        {

            User u = new User();
            u.Id = 1;
            u.Name = "Görkem";
            u.LastName = "AYDIN";
            u.BirthDate = new DateTime(2000, 10, 20);

            return View(u);
        }

        public IActionResult Book1()
        {
            var b= new Book();
            b.Id = 1;
            b.Title = "Yanlız Kurt";
            b.Author = "Jack London";
            b.Description = "Yanlız bir gezginin maceraları";
            return View("BookDetail",b);
        }
        public IActionResult Book2()
        {
            var b = new Book();
            b.Id = 2;
            b.Title = "Yüzüncü Ad";
            b.Author = "Amin Maalouf";
            b.Description = "Gerçeği arayan bir maceraperest.";
            return View("BookDetail", b);
        }


    }
}
