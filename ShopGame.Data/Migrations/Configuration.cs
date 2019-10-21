namespace ShopGame.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopGame.Data.DbModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShopGame.Data.DbModelContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

          /*  var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new DbModelContext()));
            var rolemanager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new DbModelContext()));

            //tao doi tuong
            var user = new ApplicationUser()
            {
                UserName = "duy",
                Email = "duy98@gmail.com",
                EmailConfirmed = true,
                birthday = DateTime.Now,
                fullname = "ToDinhDuy"
            };
            manager.Create(user, "12345@");

            if (!rolemanager.Roles.Any())
            {
                rolemanager.Create(new IdentityRole { Name = "Admin"});
                rolemanager.Create(new IdentityRole { Name = "User"});
            }

            var admin = manager.FindByEmail("duy98@gmail.com");

            manager.AddToRoles(admin.Id, new string[] {"Admin", "User"});
            */
        }
    }
}
