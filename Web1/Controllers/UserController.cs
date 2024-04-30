using Microsoft.AspNetCore.Mvc;
using Web1.Models;

namespace Web1.Controllers
{
    public class UserController : Controller
    {

        public List<User> Users = new List<User>();

        public UserController()
        {
            Users.Add(new User{BirthDate = new DateTime(2000, 12, 10),Id = 1,LastName = "YILMAZ",Name = "Ali"});
            Users.Add(new User{BirthDate = new DateTime(2000, 12, 10),Id = 2,LastName = "TÜRK",Name = "Ayşe"});
            Users.Add(new User{BirthDate = new DateTime(2000, 12, 10),Id = 3,LastName = "TOK",Name = "Kaan"});
            Users.Add(new User{BirthDate = new DateTime(2000, 12, 10),Id = 4,LastName = "IŞIK",Name = "Fatma"});
        }


        public IActionResult Index()
        {
            return View(Users);
        }


        public IActionResult Detail(int id) {
            
            var u=Users.FirstOrDefault(x => x.Id == id);    

            return View(u);
        }


    }
}
