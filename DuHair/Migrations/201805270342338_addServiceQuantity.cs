namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addServiceQuantity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Commissions", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Commissions", "Quantity");
        }
    }
}
