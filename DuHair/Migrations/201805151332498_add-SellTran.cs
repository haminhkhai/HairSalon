namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSellTran : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SellTranDetails",
                c => new
                    {
                        SellTranDetailId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Material_MaterialId = c.Int(),
                    })
                .PrimaryKey(t => t.SellTranDetailId)
                .ForeignKey("dbo.Materials", t => t.Material_MaterialId)
                .Index(t => t.Material_MaterialId);
            
            CreateTable(
                "dbo.SellTrans",
                c => new
                    {
                        SellMaterialId = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        SellDate = c.DateTime(nullable: false),
                        Employee_EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.SellMaterialId)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeId)
                .Index(t => t.Employee_EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SellTrans", "Employee_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.SellTranDetails", "Material_MaterialId", "dbo.Materials");
            DropIndex("dbo.SellTrans", new[] { "Employee_EmployeeId" });
            DropIndex("dbo.SellTranDetails", new[] { "Material_MaterialId" });
            DropTable("dbo.SellTrans");
            DropTable("dbo.SellTranDetails");
        }
    }
}
