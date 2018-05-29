namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMaterialDiscount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materials", "Discount", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Materials", "Discount");
        }
    }
}
