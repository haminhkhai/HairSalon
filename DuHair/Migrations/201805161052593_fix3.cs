namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SellTranDetails", "SellTran_SellTranId", c => c.Int());
            AddColumn("dbo.SellTrans", "Customer_CustomerId", c => c.Int());
            CreateIndex("dbo.SellTranDetails", "SellTran_SellTranId");
            CreateIndex("dbo.SellTrans", "Customer_CustomerId");
            AddForeignKey("dbo.SellTrans", "Customer_CustomerId", "dbo.Customers", "CustomerId");
            AddForeignKey("dbo.SellTranDetails", "SellTran_SellTranId", "dbo.SellTrans", "SellTranId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SellTranDetails", "SellTran_SellTranId", "dbo.SellTrans");
            DropForeignKey("dbo.SellTrans", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.SellTrans", new[] { "Customer_CustomerId" });
            DropIndex("dbo.SellTranDetails", new[] { "SellTran_SellTranId" });
            DropColumn("dbo.SellTrans", "Customer_CustomerId");
            DropColumn("dbo.SellTranDetails", "SellTran_SellTranId");
        }
    }
}
