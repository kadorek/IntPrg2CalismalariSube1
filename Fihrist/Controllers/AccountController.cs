using Fihrist.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Fihrist.Controllers
{
    public class AccountController : Controller
    {
        private readonly FihristContext context;
        public AccountController()
        {
            context = new FihristContext();
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login([FromForm, Bind("Username", "Password")] User dataUser)
        {
            var user = context.Users.Include("") .FirstOrDefault(x => x.Username == dataUser.Username && x.Password == dataUser.Password);
            if (user == null)
            {
                return View(dataUser);
            }


            //var allUserRoles= 


            var claims = new List<Claim> {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Name,user.Username),
                new Claim("UserPassword",user.Password),
                new Claim("UserId",user.Id.ToString())
            };


            var claimIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
            var claimPrincipal = new ClaimsPrincipal(claimIdentity);
            await HttpContext.SignInAsync(claimPrincipal);

            return RedirectToAction("Index","Home");
        }

    }
}
