namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixTransaction2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TransactionModels", "Amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TransactionModels", "Amount");
        }
    }
}
