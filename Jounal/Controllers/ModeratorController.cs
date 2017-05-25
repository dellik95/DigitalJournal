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
        AppIdentityDbContext stud = new AppIdentityDbContext();
        public ActionResult Index()
        {

            var query = from s in stud.Students
                        select s;

            return View(query.ToList());

        }

        [HttpGet]
        public ActionResult CreateStudent()
        {
            IEnumerable<SelectListItem> Grouplist = null;
            IEnumerable<SelectListItem> Courslist = null;

            Grouplist = stud.Groups.Select(c => new SelectListItem { Value = c.Group_ID.ToString(), Text = c.NumGroup }).ToList();
            Courslist = stud.Cours.Select(c => new SelectListItem { Value = c.Cours_ID.ToString(), Text = c.NumCours.ToString() }).ToList();

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
            return RedirectToRoute(new { controller = "Moderator", action = "Index" });
        }

        [HttpGet]
        public ActionResult CreateGroup()
        {
            return View();

        }

        [HttpPost]
        public async Task<ActionResult> CreateGroup(Groups group)
        {

            if (group != null)
            {
                stud.Groups.Add(group);
                await stud.SaveChangesAsync();
            }

            return RedirectToRoute(new { controller = "Moderator", action = "Index" });
        }



        public async Task<ActionResult> Delete(int id)
        {
            var query = from s in stud.Students
                        where s.Student_ID == id
                        select s;

            stud.Students.Remove(query.FirstOrDefault());
            await stud.SaveChangesAsync();
            return RedirectToRoute(new { controller = "Moderator", action = "Index" });
        }


        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            IEnumerable<SelectListItem> Grouplist = null;
            IEnumerable<SelectListItem> Courslist = null;

            Grouplist = stud.Groups.Select(c => new SelectListItem { Value = c.Group_ID.ToString(), Text = c.NumGroup }).ToList();
            Courslist = stud.Cours.Select(c => new SelectListItem { Value = c.Cours_ID.ToString(), Text = c.NumCours.ToString() }).ToList();

            ViewBag.GroupList = Grouplist;
            ViewBag.Courslist = Courslist;
            return View(await stud.Students.FindAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Students newStudent)
        {

            Students student = await stud.Students.FindAsync(newStudent.Student_ID);
            if (student != null && newStudent != null)
            {
                student.FName = newStudent.FName;
                student.SName = newStudent.SName;
                student.LName = newStudent.LName;
                student.Cours = newStudent.Cours;
                student.Cours_ID = newStudent.Cours_ID;
                student.Groups = newStudent.Groups;
                student.Group_ID = newStudent.Group_ID;
                await stud.SaveChangesAsync();
            }
            return RedirectToRoute(new { controller = "Moderator", action = "Index" });
        }
    }
}