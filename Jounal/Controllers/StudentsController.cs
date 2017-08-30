using Jounal.Models;
using System.Linq;
using System.Web.Mvc;
using Jounal.Infrastructure;

namespace Jounal.Controllers
{

    //  [Authorize]
    public class StudentsController : Controller
    {
        AppIdentityDbContext journal = new AppIdentityDbContext();
        [HttpGet]
        public ActionResult Index(int? id)
        {
            var query = (from s in journal.Students
                         where s.Group_ID == id
                         select s).ToList();
            if (query.Count > 0)
            {
                if (query.Where(x => x.Marks) == null)
                {
                    ViewBag.count = 0;
                }
                else
                {
                    ViewBag.count = query.Max(x => x.Marks.Count);
                }
            }
            else
            {
                ViewBag.count = 0;
            }

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

            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }
    }
}
