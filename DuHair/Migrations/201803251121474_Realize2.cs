namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Realize2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MaterialModels", "ServiceModel_ServiceId", "dbo.ServiceModels");
            DropIndex("dbo.MaterialModels", new[] { "ServiceModel_ServiceId" });
            CreateTable(
                "dbo.ServiceModelMaterialModels",
                c => new
                    {
                        ServiceModel_ServiceId = c.Int(nullable: false),
                        MaterialModel_MaterialId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ServiceModel_ServiceId, t.MaterialModel_MaterialId })
                .ForeignKey("dbo.ServiceModels", t => t.ServiceModel_ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.MaterialModels", t => t.MaterialModel_MaterialId, cascadeDelete: true)
                .Index(t => t.ServiceModel_ServiceId)
                .Index(t => t.MaterialModel_MaterialId);
            
            DropColumn("dbo.MaterialModels", "ServiceModel_ServiceId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MaterialModels", "ServiceModel_ServiceId", c => c.Int());
            DropForeignKey("dbo.ServiceModelMaterialModels", "MaterialModel_MaterialId", "dbo.MaterialModels");
            DropForeignKey("dbo.ServiceModelMaterialModels", "ServiceModel_ServiceId", "dbo.ServiceModels");
            DropIndex("dbo.ServiceModelMaterialModels", new[] { "MaterialModel_MaterialId" });
            DropIndex("dbo.ServiceModelMaterialModels", new[] { "ServiceModel_ServiceId" });
            DropTable("dbo.ServiceModelMaterialModels");
            CreateIndex("dbo.MaterialModels", "ServiceModel_ServiceId");
            AddForeignKey("dbo.MaterialModels", "ServiceModel_ServiceId", "dbo.ServiceModels", "ServiceId");
        }
    }
}
