namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addOtherPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Commissions", "OtherPrice", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Commissions", "OtherPrice");
        }
    }
}
