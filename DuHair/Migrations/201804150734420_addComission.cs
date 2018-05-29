namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addComission : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Commissions",
                c => new
                    {
                        ComissionId = c.Int(nullable: false, identity: true),
                        ComissionPercent = c.Int(nullable: false),
                        Employee_EmployeeId = c.Int(),
                        Transaction_TransactionId = c.Int(),
                    })
                .PrimaryKey(t => t.ComissionId)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeId)
                .ForeignKey("dbo.Transactions", t => t.Transaction_TransactionId)
                .Index(t => t.Employee_EmployeeId)
                .Index(t => t.Transaction_TransactionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Commissions", "Transaction_TransactionId", "dbo.Transactions");
            DropForeignKey("dbo.Commissions", "Employee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.Commissions", new[] { "Transaction_TransactionId" });
            DropIndex("dbo.Commissions", new[] { "Employee_EmployeeId" });
            DropTable("dbo.Commissions");
        }
    }
}
