namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsPaidWithCash : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "IsPaidWithCash", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "IsPaidWithCash");
        }
    }
}
