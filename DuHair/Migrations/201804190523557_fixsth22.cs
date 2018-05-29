namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixsth22 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Commissions", "Employee_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Commissions", "Transaction_TransactionId", "dbo.Transactions");
            DropIndex("dbo.Commissions", new[] { "Employee_EmployeeId" });
            DropIndex("dbo.Commissions", new[] { "Transaction_TransactionId" });
            DropTable("dbo.Commissions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Commissions",
                c => new
                    {
                        ComissionId = c.Int(nullable: false, identity: true),
                        CommissionPercent = c.Int(nullable: false),
                        Employee_EmployeeId = c.Int(),
                        Transaction_TransactionId = c.Int(),
                    })
                .PrimaryKey(t => t.ComissionId);
            
            CreateIndex("dbo.Commissions", "Transaction_TransactionId");
            CreateIndex("dbo.Commissions", "Employee_EmployeeId");
            AddForeignKey("dbo.Commissions", "Transaction_TransactionId", "dbo.Transactions", "TransactionId");
            AddForeignKey("dbo.Commissions", "Employee_EmployeeId", "dbo.Employees", "EmployeeId");
        }
    }
}
