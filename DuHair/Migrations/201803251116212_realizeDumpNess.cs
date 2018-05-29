namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class realizeDumpNess : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ServiceModelMaterialModels", "ServiceModel_ServiceId", "dbo.ServiceModels");
            DropForeignKey("dbo.ServiceModelMaterialModels", "MaterialModel_MaterialId", "dbo.MaterialModels");
            DropIndex("dbo.ServiceModelMaterialModels", new[] { "ServiceModel_ServiceId" });
            DropIndex("dbo.ServiceModelMaterialModels", new[] { "MaterialModel_MaterialId" });
            AddColumn("dbo.MaterialModels", "ServiceModel_ServiceId", c => c.Int());
            CreateIndex("dbo.MaterialModels", "ServiceModel_ServiceId");
            AddForeignKey("dbo.MaterialModels", "ServiceModel_ServiceId", "dbo.ServiceModels", "ServiceId");
            DropTable("dbo.ServiceModelMaterialModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ServiceModelMaterialModels",
                c => new
                    {
                        ServiceModel_ServiceId = c.Int(nullable: false),
                        MaterialModel_MaterialId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ServiceModel_ServiceId, t.MaterialModel_MaterialId });
            
            DropForeignKey("dbo.MaterialModels", "ServiceModel_ServiceId", "dbo.ServiceModels");
            DropIndex("dbo.MaterialModels", new[] { "ServiceModel_ServiceId" });
            DropColumn("dbo.MaterialModels", "ServiceModel_ServiceId");
            CreateIndex("dbo.ServiceModelMaterialModels", "MaterialModel_MaterialId");
            CreateIndex("dbo.ServiceModelMaterialModels", "ServiceModel_ServiceId");
            AddForeignKey("dbo.ServiceModelMaterialModels", "MaterialModel_MaterialId", "dbo.MaterialModels", "MaterialId", cascadeDelete: true);
            AddForeignKey("dbo.ServiceModelMaterialModels", "ServiceModel_ServiceId", "dbo.ServiceModels", "ServiceId", cascadeDelete: true);
        }
    }
}
