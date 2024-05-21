using Fihrist.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fihrist.Areas.Manegement.Controllers
{
    [Area("Manegement")]
    public class HomeController : Controller
    {
        private readonly FihristContext context;

        public HomeController()
        {
            context = new FihristContext();  
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AssingRoleToUser()
        {
           var allroles=context.Roles.ToList(); //Tüm roller alındı.
            var allusers=context.Users.ToList();//Tüm kullanıcılar alındı.
            var userselect = new SelectList(allusers, "Id", "Username"); //Select liste kullanıcı eklendi.
            var roleselect = new SelectList(allroles, "Id", "Name");//Roller select listesine eklendi.
            ViewBag.roleselect = roleselect; //Viewbage roleselect listesi eklendi.
            ViewBag.userselect = userselect; //Viewbage kullanıcıselect lisetesi eklendi.
            return View(); 
        }
    }
}
