namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bigFixAndAddingStuff : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ChairModels", newName: "Chairs");
            RenameTable(name: "dbo.CustomerModels", newName: "Customers");
            RenameTable(name: "dbo.EmployeeModels", newName: "Employees");
            RenameTable(name: "dbo.TransactionModels", newName: "Transactions");
            RenameTable(name: "dbo.ServiceModels", newName: "Services");
            RenameTable(name: "dbo.MaterialModels", newName: "Materials");
            RenameTable(name: "dbo.TransactionModelEmployeeModels", newName: "TransactionEmployees");
            RenameTable(name: "dbo.ServiceModelTransactionModels", newName: "ServiceTransactions");
            RenameTable(name: "dbo.MaterialModelServiceModels", newName: "MaterialServices");
            RenameColumn(table: "dbo.TransactionEmployees", name: "TransactionModel_TransactionId", newName: "Transaction_TransactionId");
            RenameColumn(table: "dbo.TransactionEmployees", name: "EmployeeModel_EmployeeId", newName: "Employee_EmployeeId");
            RenameColumn(table: "dbo.ServiceTransactions", name: "ServiceModel_ServiceId", newName: "Service_ServiceId");
            RenameColumn(table: "dbo.ServiceTransactions", name: "TransactionModel_TransactionId", newName: "Transaction_TransactionId");
            RenameColumn(table: "dbo.MaterialServices", name: "MaterialModel_MaterialId", newName: "Material_MaterialId");
            RenameColumn(table: "dbo.MaterialServices", name: "ServiceModel_ServiceId", newName: "Service_ServiceId");
            RenameIndex(table: "dbo.TransactionEmployees", name: "IX_TransactionModel_TransactionId", newName: "IX_Transaction_TransactionId");
            RenameIndex(table: "dbo.TransactionEmployees", name: "IX_EmployeeModel_EmployeeId", newName: "IX_Employee_EmployeeId");
            RenameIndex(table: "dbo.MaterialServices", name: "IX_MaterialModel_MaterialId", newName: "IX_Material_MaterialId");
            RenameIndex(table: "dbo.MaterialServices", name: "IX_ServiceModel_ServiceId", newName: "IX_Service_ServiceId");
            RenameIndex(table: "dbo.ServiceTransactions", name: "IX_ServiceModel_ServiceId", newName: "IX_Service_ServiceId");
            RenameIndex(table: "dbo.ServiceTransactions", name: "IX_TransactionModel_TransactionId", newName: "IX_Transaction_TransactionId");
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        WarehouseId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Material_MaterialId = c.Int(),
                    })
                .PrimaryKey(t => t.WarehouseId)
                .ForeignKey("dbo.Materials", t => t.Material_MaterialId)
                .Index(t => t.Material_MaterialId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Warehouses", "Material_MaterialId", "dbo.Materials");
            DropIndex("dbo.Warehouses", new[] { "Material_MaterialId" });
            DropTable("dbo.Warehouses");
            RenameIndex(table: "dbo.ServiceTransactions", name: "IX_Transaction_TransactionId", newName: "IX_TransactionModel_TransactionId");
            RenameIndex(table: "dbo.ServiceTransactions", name: "IX_Service_ServiceId", newName: "IX_ServiceModel_ServiceId");
            RenameIndex(table: "dbo.MaterialServices", name: "IX_Service_ServiceId", newName: "IX_ServiceModel_ServiceId");
            RenameIndex(table: "dbo.MaterialServices", name: "IX_Material_MaterialId", newName: "IX_MaterialModel_MaterialId");
            RenameIndex(table: "dbo.TransactionEmployees", name: "IX_Employee_EmployeeId", newName: "IX_EmployeeModel_EmployeeId");
            RenameIndex(table: "dbo.TransactionEmployees", name: "IX_Transaction_TransactionId", newName: "IX_TransactionModel_TransactionId");
            RenameColumn(table: "dbo.MaterialServices", name: "Service_ServiceId", newName: "ServiceModel_ServiceId");
            RenameColumn(table: "dbo.MaterialServices", name: "Material_MaterialId", newName: "MaterialModel_MaterialId");
            RenameColumn(table: "dbo.ServiceTransactions", name: "Transaction_TransactionId", newName: "TransactionModel_TransactionId");
            RenameColumn(table: "dbo.ServiceTransactions", name: "Service_ServiceId", newName: "ServiceModel_ServiceId");
            RenameColumn(table: "dbo.TransactionEmployees", name: "Employee_EmployeeId", newName: "EmployeeModel_EmployeeId");
            RenameColumn(table: "dbo.TransactionEmployees", name: "Transaction_TransactionId", newName: "TransactionModel_TransactionId");
            RenameTable(name: "dbo.MaterialServices", newName: "MaterialModelServiceModels");
            RenameTable(name: "dbo.ServiceTransactions", newName: "ServiceModelTransactionModels");
            RenameTable(name: "dbo.TransactionEmployees", newName: "TransactionModelEmployeeModels");
            RenameTable(name: "dbo.Materials", newName: "MaterialModels");
            RenameTable(name: "dbo.Services", newName: "ServiceModels");
            RenameTable(name: "dbo.Transactions", newName: "TransactionModels");
            RenameTable(name: "dbo.Employees", newName: "EmployeeModels");
            RenameTable(name: "dbo.Customers", newName: "CustomerModels");
            RenameTable(name: "dbo.Chairs", newName: "ChairModels");
        }
    }
}
