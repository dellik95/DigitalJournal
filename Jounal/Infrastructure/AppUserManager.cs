using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jounal.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Jounal.Infrastructure
{
    public class AppUserManager : UserManager<AppUser>
    {
        public AppUserManager(IUserStore<AppUser> store) : base(store)
        {
        }

        public static AppUserManager Create(IdentityFactoryOptions<AppUserManager> options , IOwinContext context)
        {
            AppIdentityDbContext db = context.Get<AppIdentityDbContext>();

            AppUserManager manager = new AppUserManager(new UserStore<AppUser>(db));
            manager.PasswordValidator = new PasswordValidator
            {
                RequireDigit=true,
                RequiredLength=8,
                RequireLowercase=true,
                RequireNonLetterOrDigit=false,
                RequireUppercase=false
            };

            manager.UserValidator = new UserValidator<AppUser>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };
            return manager;
        }
    }
}