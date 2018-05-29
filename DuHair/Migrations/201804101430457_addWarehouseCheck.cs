namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addWarehouseCheck : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WarehouseCheckDetails",
                c => new
                    {
                        WarehouseCheckDetailId = c.Int(nullable: false, identity: true),
                        OldQuantity = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Margin = c.Int(nullable: false),
                        Material_MaterialId = c.Int(),
                        WarehouseCheck_WarehouseCheckId = c.Int(),
                    })
                .PrimaryKey(t => t.WarehouseCheckDetailId)
                .ForeignKey("dbo.Materials", t => t.Material_MaterialId)
                .ForeignKey("dbo.WarehouseChecks", t => t.WarehouseCheck_WarehouseCheckId)
                .Index(t => t.Material_MaterialId)
                .Index(t => t.WarehouseCheck_WarehouseCheckId);
            
            CreateTable(
                "dbo.WarehouseChecks",
                c => new
                    {
                        WarehouseCheckId = c.Int(nullable: false, identity: true),
                        Margin = c.Int(nullable: false),
                        CheckDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.WarehouseCheckId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WarehouseCheckDetails", "WarehouseCheck_WarehouseCheckId", "dbo.WarehouseChecks");
            DropForeignKey("dbo.WarehouseCheckDetails", "Material_MaterialId", "dbo.Materials");
            DropIndex("dbo.WarehouseCheckDetails", new[] { "WarehouseCheck_WarehouseCheckId" });
            DropIndex("dbo.WarehouseCheckDetails", new[] { "Material_MaterialId" });
            DropTable("dbo.WarehouseChecks");
            DropTable("dbo.WarehouseCheckDetails");
        }
    }
}
