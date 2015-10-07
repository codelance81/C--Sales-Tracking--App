namespace SalesApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalesTarget : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SalesPersons", "SalesTarget", c => c.Decimal(nullable: false, precision: 18, scale: 2, defaultValue:1000.00m));
            AddColumn("dbo.SalesRegions", "SalesTarget", c => c.Decimal(nullable: false, precision: 18, scale: 2,defaultValue:10000.00m));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SalesRegions", "SalesTarget");
            DropColumn("dbo.SalesPersons", "SalesTarget");
        }
    }
}
