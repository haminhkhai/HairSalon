namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerModels", "Name", c => c.String());
            AlterColumn("dbo.CustomerModels", "Tel", c => c.String());
            AlterColumn("dbo.CustomerModels", "Sex", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerModels", "Sex", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.CustomerModels", "Tel", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.CustomerModels", "Name", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
