namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropThings : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transactions", "Chair_ChairId", "dbo.Chairs");
            DropIndex("dbo.Transactions", new[] { "Chair_ChairId" });
            DropColumn("dbo.Transactions", "Status");
            DropColumn("dbo.Transactions", "Chair_ChairId");
            DropTable("dbo.Chairs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Chairs",
                c => new
                    {
                        ChairId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ChairId);
            
            AddColumn("dbo.Transactions", "Chair_ChairId", c => c.Int());
            AddColumn("dbo.Transactions", "Status", c => c.Int(nullable: false));
            CreateIndex("dbo.Transactions", "Chair_ChairId");
            AddForeignKey("dbo.Transactions", "Chair_ChairId", "dbo.Chairs", "ChairId");
        }
    }
}
