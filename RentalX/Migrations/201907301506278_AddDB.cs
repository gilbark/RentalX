namespace RentalX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarMakes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassId = c.Int(nullable: false),
                        MakeId = c.Int(nullable: false),
                        CarModel = c.String(nullable: false),
                        CarMileage = c.Long(nullable: false),
                        CostPerDay = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarClasses", t => t.ClassId, cascadeDelete: true)
                .ForeignKey("dbo.CarMakes", t => t.MakeId, cascadeDelete: true)
                .Index(t => t.ClassId)
                .Index(t => t.MakeId);
            
           
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Cars", "MakeId", "dbo.CarMakes");
            DropForeignKey("dbo.Cars", "ClassId", "dbo.CarClasses");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Cars", new[] { "MakeId" });
            DropIndex("dbo.Cars", new[] { "ClassId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Cars");
            DropTable("dbo.CarMakes");
            DropTable("dbo.CarClasses");
        }
    }
}
