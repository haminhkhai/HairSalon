namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPrice2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TransactionServices", "Price2", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TransactionServices", "Price2");
        }
    }
}
