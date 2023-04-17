using SBS_2page_webApp.Models;
using System.Linq;
using System.Web.Mvc;

namespace SBS_2page_webApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly DbContextES db = new DbContextES();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            var person = db.Person.FirstOrDefault(p => p.Name == model.Username && p.Password == model.Password);

            if (person != null)
            {
                Session["PersonId"] = person.Id;
                return RedirectToAction("Index", "Info");
            }
            else
            {
                ModelState.AddModelError("", "Invalid username or password.");
                return View();
            }
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
