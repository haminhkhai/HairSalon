namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDiscountType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Commissions", "DiscountType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Commissions", "DiscountType");
        }
    }
}
