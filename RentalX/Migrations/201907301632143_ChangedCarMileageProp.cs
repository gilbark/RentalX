namespace RentalX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedCarMileageProp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "CarMileage", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "CarMileage", c => c.Long(nullable: false));
        }
    }
}
