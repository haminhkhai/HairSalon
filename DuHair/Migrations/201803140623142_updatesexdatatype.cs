namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatesexdatatype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployeeModels", "Sex", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeeModels", "Sex", c => c.Int(nullable: false));
        }
    }
}
