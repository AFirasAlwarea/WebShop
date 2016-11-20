namespace WebShop.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebShop.Models.WebShopDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebShop.Models.WebShopDB context)
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
            context.Category.AddOrUpdate(C => C.Name,
                new Category { Name = "RawMaterial" },
                new Category { Name = "FinishedGood"},
                new Category { Name = "ReturnOrDamaged"}
                );
            context.Product.AddOrUpdate(new Product { Name = "HP Laptop", Inventory = 20});
        }
    }
}
