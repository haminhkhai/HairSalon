namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixCommission1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Commissions", "Transaction_TransactionId", c => c.Int());
            CreateIndex("dbo.Commissions", "Transaction_TransactionId");
            AddForeignKey("dbo.Commissions", "Transaction_TransactionId", "dbo.Transactions", "TransactionId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Commissions", "Transaction_TransactionId", "dbo.Transactions");
            DropIndex("dbo.Commissions", new[] { "Transaction_TransactionId" });
            DropColumn("dbo.Commissions", "Transaction_TransactionId");
        }
    }
}
