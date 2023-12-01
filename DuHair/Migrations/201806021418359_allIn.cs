namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allIn : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Transaction_TransactionId", "dbo.Transactions");
            DropForeignKey("dbo.ServiceTransactions", "Service_ServiceId", "dbo.Services");
            DropForeignKey("dbo.ServiceTransactions", "Transaction_TransactionId", "dbo.Transactions");
            DropForeignKey("dbo.Transactions", "Employee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.Employees", new[] { "Transaction_TransactionId" });
            DropIndex("dbo.Transactions", new[] { "Employee_EmployeeId" });
            DropIndex("dbo.ServiceTransactions", new[] { "Service_ServiceId" });
            DropIndex("dbo.ServiceTransactions", new[] { "Transaction_TransactionId" });
            CreateTable(
                "dbo.TransactionEmployees",
                c => new
                    {
                        TransactionId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        DiscountMoney = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TransactionId, t.EmployeeId })
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Transactions", t => t.TransactionId, cascadeDelete: true)
                .Index(t => t.TransactionId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.TransactionServices",
                c => new
                    {
                        TransactionId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TransactionId, t.ServiceId })
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.Transactions", t => t.TransactionId, cascadeDelete: true)
                .Index(t => t.TransactionId)
                .Index(t => t.ServiceId);
            
            DropColumn("dbo.Employees", "ImageUrl");
            DropColumn("dbo.Employees", "Transaction_TransactionId");
            DropColumn("dbo.Transactions", "Note");
            DropColumn("dbo.Transactions", "BeforeImgUrl");
            DropColumn("dbo.Transactions", "AfterImgUrl");
            DropColumn("dbo.Transactions", "Employee_EmployeeId");
            DropTable("dbo.ServiceTransactions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ServiceTransactions",
                c => new
                    {
                        Service_ServiceId = c.Int(nullable: false),
                        Transaction_TransactionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Service_ServiceId, t.Transaction_TransactionId });
            
            AddColumn("dbo.Transactions", "Employee_EmployeeId", c => c.Int());
            AddColumn("dbo.Transactions", "AfterImgUrl", c => c.String());
            AddColumn("dbo.Transactions", "BeforeImgUrl", c => c.String());
            AddColumn("dbo.Transactions", "Note", c => c.String());
            AddColumn("dbo.Employees", "Transaction_TransactionId", c => c.Int());
            AddColumn("dbo.Employees", "ImageUrl", c => c.String());
            DropForeignKey("dbo.TransactionServices", "TransactionId", "dbo.Transactions");
            DropForeignKey("dbo.TransactionServices", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.TransactionEmployees", "TransactionId", "dbo.Transactions");
            DropForeignKey("dbo.TransactionEmployees", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.TransactionServices", new[] { "ServiceId" });
            DropIndex("dbo.TransactionServices", new[] { "TransactionId" });
            DropIndex("dbo.TransactionEmployees", new[] { "EmployeeId" });
            DropIndex("dbo.TransactionEmployees", new[] { "TransactionId" });
            DropTable("dbo.TransactionServices");
            DropTable("dbo.TransactionEmployees");
            CreateIndex("dbo.ServiceTransactions", "Transaction_TransactionId");
            CreateIndex("dbo.ServiceTransactions", "Service_ServiceId");
            CreateIndex("dbo.Transactions", "Employee_EmployeeId");
            CreateIndex("dbo.Employees", "Transaction_TransactionId");
            AddForeignKey("dbo.Transactions", "Employee_EmployeeId", "dbo.Employees", "EmployeeId");
            AddForeignKey("dbo.ServiceTransactions", "Transaction_TransactionId", "dbo.Transactions", "TransactionId", cascadeDelete: true);
            AddForeignKey("dbo.ServiceTransactions", "Service_ServiceId", "dbo.Services", "ServiceId", cascadeDelete: true);
            AddForeignKey("dbo.Employees", "Transaction_TransactionId", "dbo.Transactions", "TransactionId");
        }
    }
}
