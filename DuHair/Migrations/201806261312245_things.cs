namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class things : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "PrintCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "PrintCount");
        }
    }
}
