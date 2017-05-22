using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Jounal.Models;
using Jounal.Infrastructure;

namespace Jounal.Controllers
{
    public class ModeratorController : Controller
    {



        public ActionResult Index()
        {
            using (AppIdentityDbContext stud = new AppIdentityDbContext())
            {

                var query = from s in stud.Students
                            select s;

                return View(query.ToList());
            }
        }

        [HttpGet]
        public ActionResult CreateStudent()
        {
            IEnumerable<SelectListItem> Grouplist = null;
            IEnumerable<SelectListItem> Courslist = null;
            using (AppIdentityDbContext stud = new AppIdentityDbContext())
            {
                Grouplist = stud.Groups.Select(c => new SelectListItem { Value = c.Group_ID.ToString(), Text = c.NumGroup }).ToList();
                Courslist = stud.Cours.Select(c => new SelectListItem { Value = c.Cours_ID.ToString(), Text = c.NumCours.ToString() }).ToList();
            }
            ViewBag.GroupList = Grouplist;
            ViewBag.Courslist = Courslist;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateStudent(Students newStudent)
        {
            using (AppIdentityDbContext stud = new AppIdentityDbContext())
            {
                if (newStudent != null)
                {
                    stud.Students.Add(newStudent);
                    await stud.SaveChangesAsync();
                }
            }
            return RedirectToRoute("Admin/Index");
        }

        [HttpGet]
        public ActionResult CreateGroup()
        {
            return View();

        }

        [HttpPost]
        public async Task<ActionResult> CreateGroup(Groups group)
        {
            using (AppIdentityDbContext stud = new AppIdentityDbContext())
            {
                if (group != null)
                {
                    stud.Groups.Add(group);
                    await stud.SaveChangesAsync();
                }
            }

            return RedirectToRoute(new { controller = "Admin", action = "Index" });
        }
    }
}