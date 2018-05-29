namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRelationShip : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ServiceModelMaterialModels", newName: "MaterialModelServiceModels");
            DropPrimaryKey("dbo.MaterialModelServiceModels");
            CreateTable(
                "dbo.ServiceModelTransactionModels",
                c => new
                    {
                        ServiceModel_ServiceId = c.Int(nullable: false),
                        TransactionModel_TransactionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ServiceModel_ServiceId, t.TransactionModel_TransactionId })
                .ForeignKey("dbo.ServiceModels", t => t.ServiceModel_ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.TransactionModels", t => t.TransactionModel_TransactionId, cascadeDelete: true)
                .Index(t => t.ServiceModel_ServiceId)
                .Index(t => t.TransactionModel_TransactionId);
            
            AddPrimaryKey("dbo.MaterialModelServiceModels", new[] { "MaterialModel_MaterialId", "ServiceModel_ServiceId" });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceModelTransactionModels", "TransactionModel_TransactionId", "dbo.TransactionModels");
            DropForeignKey("dbo.ServiceModelTransactionModels", "ServiceModel_ServiceId", "dbo.ServiceModels");
            DropIndex("dbo.ServiceModelTransactionModels", new[] { "TransactionModel_TransactionId" });
            DropIndex("dbo.ServiceModelTransactionModels", new[] { "ServiceModel_ServiceId" });
            DropPrimaryKey("dbo.MaterialModelServiceModels");
            DropTable("dbo.ServiceModelTransactionModels");
            AddPrimaryKey("dbo.MaterialModelServiceModels", new[] { "ServiceModel_ServiceId", "MaterialModel_MaterialId" });
            RenameTable(name: "dbo.MaterialModelServiceModels", newName: "ServiceModelMaterialModels");
        }
    }
}
