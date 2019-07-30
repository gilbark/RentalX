namespace RentalX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingdata : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT CarMakes ON");
            Sql("INSERT INTO CarMakes(Id, Name) VALUES (1, 'Mazda')");
            Sql("INSERT INTO CarMakes(Id, Name) VALUES (2, 'Audi')");
            Sql("INSERT INTO CarMakes(Id, Name) VALUES (3, 'BMW')");
            Sql("INSERT INTO CarMakes(Id, Name) VALUES (4, 'Mercedes')");
            Sql("INSERT INTO CarMakes(Id, Name) VALUES (5, 'Opel')");
            Sql("SET IDENTITY_INSERT CarMakes OFF");

            Sql("SET IDENTITY_INSERT CarClasses ON");
            Sql("INSERT INTO CarClasses(Id, Name) VALUES (1, 'Regular')");
            Sql("INSERT INTO CarClasses(Id, Name) VALUES (2, 'Family')");
            Sql("INSERT INTO CarClasses(Id, Name) VALUES (3, 'Luxury')");
            Sql("INSERT INTO CarClasses(Id, Name) VALUES (4, 'SUV')");
            Sql("SET IDENTITY_INSERT CarClasses OFF");

        }

        public override void Down()
        {
        }
    }
}
