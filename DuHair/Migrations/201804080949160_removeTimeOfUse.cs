namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeTimeOfUse : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Materials", "TimeOfUse");
            DropColumn("dbo.Warehouses", "TimeOfUse");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Warehouses", "TimeOfUse", c => c.Int(nullable: false));
            AddColumn("dbo.Materials", "TimeOfUse", c => c.Int(nullable: false));
        }
    }
}
