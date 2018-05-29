namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixMaterial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RestockDetails", "PriceBuy", c => c.Int(nullable: false));
            DropColumn("dbo.RestockDetails", "AmountMoney");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RestockDetails", "AmountMoney", c => c.Int(nullable: false));
            DropColumn("dbo.RestockDetails", "PriceBuy");
        }
    }
}
