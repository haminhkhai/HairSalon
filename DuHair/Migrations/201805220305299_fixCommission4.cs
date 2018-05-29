namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixCommission4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Commissions", "ComType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Commissions", "ComType");
        }
    }
}
