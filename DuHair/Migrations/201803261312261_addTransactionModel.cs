namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTransactionModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TransactionModels",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        TransactionDate = c.DateTime(nullable: false),
                        BeforeImgUrl = c.String(),
                        AfterImgUrl = c.String(),
                        Customers_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.TransactionId)
                .ForeignKey("dbo.CustomerModels", t => t.Customers_CustomerId)
                .Index(t => t.Customers_CustomerId);
            
            CreateTable(
                "dbo.TransactionModelEmployeeModels",
                c => new
                    {
                        TransactionModel_TransactionId = c.Int(nullable: false),
                        EmployeeModel_EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TransactionModel_TransactionId, t.EmployeeModel_EmployeeId })
                .ForeignKey("dbo.TransactionModels", t => t.TransactionModel_TransactionId, cascadeDelete: true)
                .ForeignKey("dbo.EmployeeModels", t => t.EmployeeModel_EmployeeId, cascadeDelete: true)
                .Index(t => t.TransactionModel_TransactionId)
                .Index(t => t.EmployeeModel_EmployeeId);
            
            AlterColumn("dbo.EmployeeModels", "Name", c => c.String());
            AlterColumn("dbo.EmployeeModels", "Tel", c => c.String());
            AlterColumn("dbo.EmployeeModels", "Sex", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionModelEmployeeModels", "EmployeeModel_EmployeeId", "dbo.EmployeeModels");
            DropForeignKey("dbo.TransactionModelEmployeeModels", "TransactionModel_TransactionId", "dbo.TransactionModels");
            DropForeignKey("dbo.TransactionModels", "Customers_CustomerId", "dbo.CustomerModels");
            DropIndex("dbo.TransactionModelEmployeeModels", new[] { "EmployeeModel_EmployeeId" });
            DropIndex("dbo.TransactionModelEmployeeModels", new[] { "TransactionModel_TransactionId" });
            DropIndex("dbo.TransactionModels", new[] { "Customers_CustomerId" });
            AlterColumn("dbo.EmployeeModels", "Sex", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.EmployeeModels", "Tel", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.EmployeeModels", "Name", c => c.String(nullable: false, maxLength: 100));
            DropTable("dbo.TransactionModelEmployeeModels");
            DropTable("dbo.TransactionModels");
        }
    }
}
