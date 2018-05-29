namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixChair : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChairModels",
                c => new
                    {
                        ChairId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ChairId);
            
            AlterColumn("dbo.TransactionModels", "Chair_ChairId", c => c.Int());
            CreateIndex("dbo.TransactionModels", "Chair_ChairId");
            AddForeignKey("dbo.TransactionModels", "Chair_ChairId", "dbo.ChairModels", "ChairId");
            DropColumn("dbo.TransactionModels", "Chair_Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TransactionModels", "Chair_Name", c => c.String());
            DropForeignKey("dbo.TransactionModels", "Chair_ChairId", "dbo.ChairModels");
            DropIndex("dbo.TransactionModels", new[] { "Chair_ChairId" });
            AlterColumn("dbo.TransactionModels", "Chair_ChairId", c => c.Int(nullable: false));
            DropTable("dbo.ChairModels");
        }
    }
}
