using Jounal.Models;
using System.Linq;
using System.Web.Mvc;
using Jounal.Infrastructure;

namespace Jounal.Controllers
{

    [Authorize]
    public class StudentsController : Controller
    {
        AppIdentityDbContext journal = new AppIdentityDbContext();
        [HttpGet]
        public ActionResult Index(int? id)
        {
            var query = (from s in journal.Students
                         where s.Group_ID == id
                         select s);

            ViewBag.count = (query.ToList().Max(x => x.Marks.Count));
            
            ViewBag.groupId = id;
            
            return View(query.ToList());
        }
        [HttpPost]
        public ActionResult Index(int[] ids, int[] mark, int? groupId)
        {
            for (int i = 0; i < ids.Length; i++)
            {

                Marks m = new Marks
                {
                    Student_ID = (short)ids[i],
                    Mark = mark[i],
                    Subjects_ID = 1,
                    Group_ID = 1
                };
                journal.Marks.Add(m);
                journal.SaveChanges();
            }

            var query = from s in journal.Students
                        where s.Group_ID == (short)groupId
                        select s;

            // ViewBag.count = (journal.Students.Max(m => m.Marks.Count));

            // return View("",query.ToList());
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }
    }
}