namespace SalesApp2.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SalesApp2.Data.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        //populate database
        protected override void Seed(SalesApp2.Data.SalesContext context)
        {
            context.Regions.AddOrUpdate(
                p => p.Id,
                new SalesRegion
                {
                    Active = true,
                    Code = "NTH",
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    Id = 1,
                    Name = "North Region",
                    SalesTarget = 1000.00m,
                    UpdatedBy = "Admin",
                    Updatedate = DateTime.Now
                },
                new SalesRegion
                {
                    Active = true,
                    Code = "STH",
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    Id = 2,
                    Name = "South Region",
                    SalesTarget = 1000.00m,
                    UpdatedBy = "Admin",
                    Updatedate = DateTime.Now

                });
            context.People.AddOrUpdate(
               p => p.Id,
               new SalesPerson
               {
                   Active = true,
                   CreatedBy = "Admin",
                   CreatedDate = DateTime.Now,
                   FirstName = "Bob",
                   Id = 1,
                   LastName ="Johnson",
                   RegionId = 1,
                   SalesTarget = 2000.00m,
                   UpdatedBy = "Admin",
                   Updatedate = DateTime.Now
               });
            context.Sales.AddOrUpdate(
               p => p.Id,
               new Sale

               {
                  Amount = 321.45m,
                   CreatedBy = "Admin",
                   CreatedDate = DateTime.Now,
                   Date = new DateTime(2014, 2, 3),
                   Id = 1,
                   PersonId =1,
                   RegionId = 1,
                   UpdatedBy = "Admin",
                   Updatedate = DateTime.Now
               });




        }
    }
}
