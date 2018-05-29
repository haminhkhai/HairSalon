namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixCommission : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Commissions", "Transaction_TransactionId", "dbo.Transactions");
            DropIndex("dbo.Commissions", new[] { "Transaction_TransactionId" });
            AddColumn("dbo.Commissions", "Service_ServiceId", c => c.Int());
            CreateIndex("dbo.Commissions", "Service_ServiceId");
            AddForeignKey("dbo.Commissions", "Service_ServiceId", "dbo.Services", "ServiceId");
            DropColumn("dbo.Commissions", "Transaction_TransactionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Commissions", "Transaction_TransactionId", c => c.Int());
            DropForeignKey("dbo.Commissions", "Service_ServiceId", "dbo.Services");
            DropIndex("dbo.Commissions", new[] { "Service_ServiceId" });
            DropColumn("dbo.Commissions", "Service_ServiceId");
            CreateIndex("dbo.Commissions", "Transaction_TransactionId");
            AddForeignKey("dbo.Commissions", "Transaction_TransactionId", "dbo.Transactions", "TransactionId");
        }
    }
}
