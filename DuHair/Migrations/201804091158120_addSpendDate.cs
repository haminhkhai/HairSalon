namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSpendDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SpendNotes", "SpendDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SpendNotes", "SpendDate");
        }
    }
}
