namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixSellTranDetail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SellTranDetails", "Discount", c => c.Single(nullable: false));
            DropColumn("dbo.SellTrans", "DiscountMoney");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SellTrans", "DiscountMoney", c => c.Int(nullable: false));
            DropColumn("dbo.SellTranDetails", "Discount");
        }
    }
}
