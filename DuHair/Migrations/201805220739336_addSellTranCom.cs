namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSellTranCom : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SellTranDetails", "SellTranCom", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SellTranDetails", "SellTranCom");
        }
    }
}
