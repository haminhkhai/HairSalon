namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNoteToWarehouseCheck : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WarehouseChecks", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WarehouseChecks", "Note");
        }
    }
}
