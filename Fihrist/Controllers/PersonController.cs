using Fihrist.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fihrist.Controllers
{
    public class PersonController : Controller
    {

        FihristContext FihristContext { get; set; }
        public PersonController()
        {
            FihristContext = new FihristContext();
        }
        public IActionResult Index()
        {
            var people = FihristContext.People.ToList();
            return View(people);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([FromForm] Person data)
        {
            if (ModelState.IsValid)
            {
                FihristContext.People.Add(data);
                FihristContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(data);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var person = FihristContext.People.FirstOrDefault(x => x.Id == id);
            return View(person);
        }
        [HttpPost]
        public IActionResult Edit([FromForm] Person data)
        {

            if (ModelState.IsValid)
            {
                FihristContext.People.Update(data);
                FihristContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(data);
        }
        public IActionResult Delete(int id)
        {
            var p = FihristContext.People.FirstOrDefault(x => x.Id == id);
            return View(p);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var p = FihristContext.People.FirstOrDefault(x => x.Id == id); 
            FihristContext.People.Remove(p);
            var count = FihristContext.SaveChanges();
            if (count > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Delete",p);
            }
        }


    }
}
