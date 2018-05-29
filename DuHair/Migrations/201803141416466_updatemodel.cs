namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemodel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployeeModels", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.EmployeeModels", "Tel", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.EmployeeModels", "Sex", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeeModels", "Sex", c => c.String());
            AlterColumn("dbo.EmployeeModels", "Tel", c => c.String());
            AlterColumn("dbo.EmployeeModels", "Name", c => c.String());
        }
    }
}
