namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixTransaction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TransactionModels", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TransactionModels", "Note");
        }
    }
}
