using SalesApp2.Interfaces;
using SalesApp2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp2.Data
{
    class SalesContext :DbContext
        //keeps changes sets deleted records to false but does not delete it from the database 
    {
        public DbSet<Sale>Sales { get; set; }

        public DbSet<SalesPerson> People { get; set; }

        public DbSet<SalesRegion> Regions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //adding a model as a table w/o a db set 
            //modelBuilder.Entity<myModel>();

            // can modify  example shows how to reuire a person  in the sales table 
           // modelBuilder.Entity<Sale>().HasRequired(e => e.Person);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            
            var stateManger = ((IObjectContextAdapter)this).ObjectContext.ObjectStateManager;

            var deletedEntities = stateManger
                .GetObjectStateEntries(EntityState.Deleted)
                .Select(e => e.Entity)
                .OfType<IActive>()
                .ToArray();

            foreach (var deletedEntity in deletedEntities)
            {
                if (deletedEntity == null) continue;
                stateManger.ChangeObjectState(deletedEntity, EntityState.Modified);
                deletedEntity.Active = false;
            }
            var createdEntities = stateManger
             .GetObjectStateEntries(EntityState.Added)
             .Select(e => e.Entity)
             .OfType<BaseModel>()
             .ToArray();

            foreach (var createdEntity in createdEntities)
            {
                createdEntity.CreatedDate = DateTime.Now;
                createdEntity.CreatedBy = Environment.UserName;
                createdEntity.Updatedate = DateTime.Now;
                createdEntity.UpdatedBy = Environment.UserName;
            }

            var updatedEntities = stateManger
           .GetObjectStateEntries(EntityState.Modified)
           .Select(e => e.Entity)
           .OfType<BaseModel>()
           .ToArray();

            foreach (var updatedEntity in updatedEntities)
            {
                updatedEntity.Updatedate = DateTime.Now;
                updatedEntity.UpdatedBy = Environment.UserName;
            }

            return base.SaveChanges();
        }

    }
}
