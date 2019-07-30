namespace RentalX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedcars : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Cars ON");
            Sql("INSERT INTO Cars(Id, ClassId, MakeId, CarModel, CarMileage, CostPerDay) VALUES (1, 1, 1, 'Mazda 3', 35000, 35)");
            Sql("INSERT INTO Cars(Id, ClassId, MakeId, CarModel, CarMileage, CostPerDay) VALUES (2, 3, 2, 'TT', 15000, 85)");
            Sql("INSERT INTO Cars(Id, ClassId, MakeId, CarModel, CarMileage, CostPerDay) VALUES (3, 2, 5, 'Insignia', 100000, 55)");

            Sql("SET IDENTITY_INSERT Cars OFF");
        }
        
        public override void Down()
        {
        }
    }
}
