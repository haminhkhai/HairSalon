namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixTimeKeepingDetail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TkDetails", "RealWage", c => c.Int(nullable: false));
            AlterColumn("dbo.TimeKeepings", "WorkingDay", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TimeKeepings", "WorkingDay", c => c.Int(nullable: false));
            DropColumn("dbo.TkDetails", "RealWage");
        }
    }
}
