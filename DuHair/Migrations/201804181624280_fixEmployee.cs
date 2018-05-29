namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Username", c => c.String());
            AddColumn("dbo.Employees", "Pwwd", c => c.String());
            AddColumn("dbo.Employees", "Role", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Role");
            DropColumn("dbo.Employees", "Pwwd");
            DropColumn("dbo.Employees", "Username");
        }
    }
}
