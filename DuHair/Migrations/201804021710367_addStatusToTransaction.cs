namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStatusToTransaction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TransactionModels", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TransactionModels", "Status");
        }
    }
}
