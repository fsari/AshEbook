using AshEbook.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AshEbook.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AshEbook.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "AshEbook.Models.ApplicationDbContext";
        }

        protected override void Seed(AshEbook.Models.ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            var userManager = new UserManager<ApplicationUser>(new ApplicationUserStore<ApplicationUser>(context));

            var user = userManager.FindByNameAsync("admin").Result;

            if (user == null)
            {
                user = new ApplicationUser();
                user.UserName = "admin";
                user.EmailAddress = "mrdiesel@gmail.com";
                user.FullName = "serkan atagun";

                userManager.Create(user, "atagun");

                userManager.AddToRole(user.Id, "manager");
            }

            if (!roleManager.RoleExists("manager"))
            {
                var role = new IdentityRole();
                role.Name = "manager";
                roleManager.Create(role);

                var userRole = new IdentityRole();
                userRole.Name = "user";
                roleManager.Create(role);

            }


            var userInRole = userManager.IsInRole(user.Id, "manager");

            if (userInRole == false)
            {
                userManager.AddToRole(user.Id, "manager");
            }
        }
    }
}
