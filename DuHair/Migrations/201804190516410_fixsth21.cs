namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixsth21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Commissions", "CommissionPercent", c => c.Int(nullable: false));
            DropColumn("dbo.Commissions", "ComissionPercent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Commissions", "ComissionPercent", c => c.Int(nullable: false));
            DropColumn("dbo.Commissions", "CommissionPercent");
        }
    }
}
