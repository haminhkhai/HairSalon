namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixServiceCommission : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "SellDiscount", c => c.Single(nullable: false));
            DropColumn("dbo.Commissions", "SellComPercent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Commissions", "SellComPercent", c => c.Int(nullable: false));
            DropColumn("dbo.Services", "SellDiscount");
        }
    }
}
