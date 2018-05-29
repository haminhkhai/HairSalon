namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixCommission21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Commissions", "ComMoney", c => c.Int(nullable: false));
            AddColumn("dbo.Commissions", "SellComMoney", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Commissions", "SellComMoney");
            DropColumn("dbo.Commissions", "ComMoney");
        }
    }
}
