using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jounal.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Microsoft.AspNet.Identity;

namespace Jounal.Infrastructure
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {

        public virtual DbSet<Academic_degree> Academic_degree { get; set; }
        public virtual DbSet<Authorizations> Authorizations { get; set; }
        public virtual DbSet<Cathedra> Cathedra { get; set; }
        public virtual DbSet<Cours> Cours { get; set; }
        public virtual DbSet<Curriculum> Curriculum { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<GroupsSubjects> GroupsSubjects { get; set; }
        public virtual DbSet<Marks> Marks { get; set; }
        public virtual DbSet<Number_lab_modules> Number_lab_modules { get; set; }
        public virtual DbSet<Number_of_modules> Number_of_modules { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Statuss> Statuss { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<TeacherCathedra> TeacherCathedra { get; set; }
        public virtual DbSet<TeacherSubjectsStatus> TeacherSubjectsStatus { get; set; }


        public AppIdentityDbContext() : base("name = DBModel") { }



        static AppIdentityDbContext()
        {
            Database.SetInitializer<AppIdentityDbContext>(new IdentityDbInit());
        }

        public static AppIdentityDbContext Create()
        {
            return new AppIdentityDbContext();
        }

    }

    public class IdentityDbInit : DropCreateDatabaseIfModelChanges<AppIdentityDbContext>
    {
        protected override void Seed(AppIdentityDbContext context)
        {
            PerformInitialSetup(context);
            base.Seed(context);
        }
        public void PerformInitialSetup(AppIdentityDbContext context)
        {
            AppUserManager userMgr = new AppUserManager(new UserStore<AppUser>(context));
            AppRoleManager roleMgr = new AppRoleManager(new RoleStore<AppRole>(context));

            string roleName = "Administrators";
            string userName = "Admin";
            string password = "mypassword";
            string email = "admin@professorweb.ru";

            if (!roleMgr.RoleExists(roleName))
            {
                roleMgr.Create(new AppRole(roleName));
            }

            AppUser user = userMgr.FindByName(userName);
            if (user == null)
            {
                userMgr.Create(new AppUser { UserName = userName, Email = email },
                    password);
                user = userMgr.FindByName(userName);
            }

            if (!userMgr.IsInRole(user.Id, roleName))
            {
                userMgr.AddToRole(user.Id, roleName);
            }
        }
    }

}
