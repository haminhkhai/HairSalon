namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rename : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SellTranDetails", "SellComMoney", c => c.Int(nullable: false));
            DropColumn("dbo.SellTranDetails", "SellTranCom");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SellTranDetails", "SellTranCom", c => c.Int(nullable: false));
            DropColumn("dbo.SellTranDetails", "SellComMoney");
        }
    }
}
