namespace RentalX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdentityModelsChangedMBRevert : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "DrivingLicenseNumber", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.AspNetUsers", "Birthdate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.String());
            DropColumn("dbo.AspNetUsers", "Birthdate");
            DropColumn("dbo.AspNetUsers", "DrivingLicenseNumber");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
