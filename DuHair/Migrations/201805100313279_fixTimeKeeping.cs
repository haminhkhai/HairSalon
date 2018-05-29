namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixTimeKeeping : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TkDetails", "Overtime", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TkDetails", "Overtime");
        }
    }
}
