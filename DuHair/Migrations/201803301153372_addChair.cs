namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addChair : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.TransactionModels", name: "Customers_CustomerId", newName: "Customer_CustomerId");
            RenameIndex(table: "dbo.TransactionModels", name: "IX_Customers_CustomerId", newName: "IX_Customer_CustomerId");
            AddColumn("dbo.TransactionModels", "Chair_ChairId", c => c.Int(nullable: false));
            AddColumn("dbo.TransactionModels", "Chair_Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TransactionModels", "Chair_Name");
            DropColumn("dbo.TransactionModels", "Chair_ChairId");
            RenameIndex(table: "dbo.TransactionModels", name: "IX_Customer_CustomerId", newName: "IX_Customers_CustomerId");
            RenameColumn(table: "dbo.TransactionModels", name: "Customer_CustomerId", newName: "Customers_CustomerId");
        }
    }
}
