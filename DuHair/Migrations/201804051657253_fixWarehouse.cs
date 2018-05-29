namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixWarehouse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Warehouses", "TimeOfUse", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Warehouses", "TimeOfUse");
        }
    }
}
