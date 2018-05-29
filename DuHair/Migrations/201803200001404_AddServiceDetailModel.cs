namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddServiceDetailModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceDetailModels",
                c => new
                    {
                        ServiceId = c.Int(nullable: false),
                        MaterialId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ServiceId, t.MaterialId })
                .ForeignKey("dbo.MaterialModels", t => t.MaterialId, cascadeDelete: true)
                .ForeignKey("dbo.ServiceModels", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.ServiceId)
                .Index(t => t.MaterialId);
            
            CreateTable(
                "dbo.ServiceModels",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Discount = c.Single(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ServiceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceDetailModels", "ServiceId", "dbo.ServiceModels");
            DropForeignKey("dbo.ServiceDetailModels", "MaterialId", "dbo.MaterialModels");
            DropIndex("dbo.ServiceDetailModels", new[] { "MaterialId" });
            DropIndex("dbo.ServiceDetailModels", new[] { "ServiceId" });
            DropTable("dbo.ServiceModels");
            DropTable("dbo.ServiceDetailModels");
        }
    }
}
