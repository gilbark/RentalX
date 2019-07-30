namespace RentalX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerController : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.String());
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "DrivingLicenseNumber");
            DropColumn("dbo.AspNetUsers", "Birthdate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Birthdate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "DrivingLicenseNumber", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.String(nullable: false));
        }
    }
}
