namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeServiceDetail : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ServiceDetailModels", "MaterialId", "dbo.MaterialModels");
            DropForeignKey("dbo.ServiceDetailModels", "ServiceId", "dbo.ServiceModels");
            DropIndex("dbo.ServiceDetailModels", new[] { "ServiceId" });
            DropIndex("dbo.ServiceDetailModels", new[] { "MaterialId" });
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
            
            DropTable("dbo.ServiceDetailModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ServiceDetailModels",
                c => new
                    {
                        ServiceId = c.Int(nullable: false),
                        MaterialId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ServiceId, t.MaterialId });
            
            DropForeignKey("dbo.ServiceModelMaterialModels", "MaterialModel_MaterialId", "dbo.MaterialModels");
            DropForeignKey("dbo.ServiceModelMaterialModels", "ServiceModel_ServiceId", "dbo.ServiceModels");
            DropIndex("dbo.ServiceModelMaterialModels", new[] { "MaterialModel_MaterialId" });
            DropIndex("dbo.ServiceModelMaterialModels", new[] { "ServiceModel_ServiceId" });
            DropTable("dbo.ServiceModelMaterialModels");
            CreateIndex("dbo.ServiceDetailModels", "MaterialId");
            CreateIndex("dbo.ServiceDetailModels", "ServiceId");
            AddForeignKey("dbo.ServiceDetailModels", "ServiceId", "dbo.ServiceModels", "ServiceId", cascadeDelete: true);
            AddForeignKey("dbo.ServiceDetailModels", "MaterialId", "dbo.MaterialModels", "MaterialId", cascadeDelete: true);
        }
    }
}
