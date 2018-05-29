namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SellTranDetails", "Material_MaterialId", "dbo.Materials");
            DropForeignKey("dbo.SellTrans", "Employee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.SellTranDetails", new[] { "Material_MaterialId" });
            DropIndex("dbo.SellTrans", new[] { "Employee_EmployeeId" });
            DropTable("dbo.SellTranDetails");
            DropTable("dbo.SellTrans");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SellTrans",
                c => new
                    {
                        SellMaterialId = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        SellDate = c.DateTime(nullable: false),
                        Employee_EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.SellMaterialId);
            
            CreateTable(
                "dbo.SellTranDetails",
                c => new
                    {
                        SellTranDetailId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Material_MaterialId = c.Int(),
                    })
                .PrimaryKey(t => t.SellTranDetailId);
            
            CreateIndex("dbo.SellTrans", "Employee_EmployeeId");
            CreateIndex("dbo.SellTranDetails", "Material_MaterialId");
            AddForeignKey("dbo.SellTrans", "Employee_EmployeeId", "dbo.Employees", "EmployeeId");
            AddForeignKey("dbo.SellTranDetails", "Material_MaterialId", "dbo.Materials", "MaterialId");
        }
    }
}
