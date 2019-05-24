namespace WebShopper.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebShopper.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebShopper.Models.ApplicationDbContext";
        }

        protected override void Seed(WebShopper.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Products.AddOrUpdate(
              p => p.ProductName,
              new Product
              {
                  ProductName = "500 base unit",
                  Category = "Kitchen",
                  IsActive = true,
                  CreatedDate = new DateTime(2016, 10, 2),
                  Description = "Wow this is great",
                  Price = 25
              },

              new Product
              {
                  ProductName = "300 base unit",
                  Category = "Kitchen",
                  IsActive = true,
                  CreatedDate = new DateTime(2016, 10, 2),
                  Description = "Wow this is great",
                  Price = 22
              },

              new Product
              {
                  ProductName = "Tulips",
                  Category = "Garden",
                  IsActive = true,
                  CreatedDate = new DateTime(2016, 10, 2),
                  Description = "purple tulips",
                  Price = 12
              },

              new Product
              {
                  ProductName = "Daffodils",
                  Category = "Garden",
                  IsActive = true,
                  CreatedDate = new DateTime(2016, 10, 2),
                  Description = "double head daffs",
                  Price = 15
              }
            );

        }

    }
}
