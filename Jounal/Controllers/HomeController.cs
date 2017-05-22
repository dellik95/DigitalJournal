using System.Linq;
using System.Web.Mvc;
using Jounal.Models;
using Jounal.Infrastructure;

namespace Jounal.Controllers
{

    public class HomeController : Controller
    {

        AppIdentityDbContext journal = new AppIdentityDbContext();
        [Authorize]
        public ActionResult Index()
        {


            IQueryable<Groups> query = from g in journal.Groups
                                       select g;

            return View(query.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "NAU Forever";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacts";

            return View();
        }
    }
}