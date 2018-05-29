namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRestock : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RestockDetails",
                c => new
                    {
                        RestockDetailId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        AmountMoney = c.Int(nullable: false),
                        Material_MaterialId = c.Int(),
                        Restock_RestockId = c.Int(),
                    })
                .PrimaryKey(t => t.RestockDetailId)
                .ForeignKey("dbo.Materials", t => t.Material_MaterialId)
                .ForeignKey("dbo.Restocks", t => t.Restock_RestockId)
                .Index(t => t.Material_MaterialId)
                .Index(t => t.Restock_RestockId);
            
            CreateTable(
                "dbo.Restocks",
                c => new
                    {
                        RestockId = c.Int(nullable: false, identity: true),
                        AmountMoney = c.Int(nullable: false),
                        RestockDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RestockId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RestockDetails", "Restock_RestockId", "dbo.Restocks");
            DropForeignKey("dbo.RestockDetails", "Material_MaterialId", "dbo.Materials");
            DropIndex("dbo.RestockDetails", new[] { "Restock_RestockId" });
            DropIndex("dbo.RestockDetails", new[] { "Material_MaterialId" });
            DropTable("dbo.Restocks");
            DropTable("dbo.RestockDetails");
        }
    }
}
