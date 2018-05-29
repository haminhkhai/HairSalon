namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCasher : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TransactionEmployees", "Transaction_TransactionId", "dbo.Transactions");
            DropForeignKey("dbo.TransactionEmployees", "Employee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.TransactionEmployees", new[] { "Transaction_TransactionId" });
            DropIndex("dbo.TransactionEmployees", new[] { "Employee_EmployeeId" });
            AddColumn("dbo.Employees", "Transaction_TransactionId", c => c.Int());
            AddColumn("dbo.Transactions", "Casher_EmployeeId", c => c.Int());
            AddColumn("dbo.Transactions", "Employee_EmployeeId", c => c.Int());
            AddColumn("dbo.SellTrans", "Casher_EmployeeId", c => c.Int());
            CreateIndex("dbo.Employees", "Transaction_TransactionId");
            CreateIndex("dbo.Transactions", "Casher_EmployeeId");
            CreateIndex("dbo.Transactions", "Employee_EmployeeId");
            CreateIndex("dbo.SellTrans", "Casher_EmployeeId");
            AddForeignKey("dbo.Transactions", "Casher_EmployeeId", "dbo.Employees", "EmployeeId");
            AddForeignKey("dbo.Employees", "Transaction_TransactionId", "dbo.Transactions", "TransactionId");
            AddForeignKey("dbo.Transactions", "Employee_EmployeeId", "dbo.Employees", "EmployeeId");
            AddForeignKey("dbo.SellTrans", "Casher_EmployeeId", "dbo.Employees", "EmployeeId");
            DropTable("dbo.TransactionEmployees");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TransactionEmployees",
                c => new
                    {
                        Transaction_TransactionId = c.Int(nullable: false),
                        Employee_EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Transaction_TransactionId, t.Employee_EmployeeId });
            
            DropForeignKey("dbo.SellTrans", "Casher_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Transactions", "Employee_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Transaction_TransactionId", "dbo.Transactions");
            DropForeignKey("dbo.Transactions", "Casher_EmployeeId", "dbo.Employees");
            DropIndex("dbo.SellTrans", new[] { "Casher_EmployeeId" });
            DropIndex("dbo.Transactions", new[] { "Employee_EmployeeId" });
            DropIndex("dbo.Transactions", new[] { "Casher_EmployeeId" });
            DropIndex("dbo.Employees", new[] { "Transaction_TransactionId" });
            DropColumn("dbo.SellTrans", "Casher_EmployeeId");
            DropColumn("dbo.Transactions", "Employee_EmployeeId");
            DropColumn("dbo.Transactions", "Casher_EmployeeId");
            DropColumn("dbo.Employees", "Transaction_TransactionId");
            CreateIndex("dbo.TransactionEmployees", "Employee_EmployeeId");
            CreateIndex("dbo.TransactionEmployees", "Transaction_TransactionId");
            AddForeignKey("dbo.TransactionEmployees", "Employee_EmployeeId", "dbo.Employees", "EmployeeId", cascadeDelete: true);
            AddForeignKey("dbo.TransactionEmployees", "Transaction_TransactionId", "dbo.Transactions", "TransactionId", cascadeDelete: true);
        }
    }
}
