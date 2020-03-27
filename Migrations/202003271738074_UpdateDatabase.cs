namespace Rent_A_Car.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "ManufacturerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "ManufacturerId");
            AddForeignKey("dbo.Cars", "ManufacturerId", "dbo.Manufacturers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.Cars", new[] { "ManufacturerId" });
            DropColumn("dbo.Cars", "ManufacturerId");
        }
    }
}
