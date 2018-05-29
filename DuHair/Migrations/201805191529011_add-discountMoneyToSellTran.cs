namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddiscountMoneyToSellTran : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SellTrans", "DiscountMoney", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SellTrans", "DiscountMoney");
        }
    }
}
