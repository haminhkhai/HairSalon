namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixCommission2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Commissions", "SellComPercent", c => c.Int(nullable: false));
            AddColumn("dbo.Commissions", "SellEmployee_EmployeeId", c => c.Int());
            CreateIndex("dbo.Commissions", "SellEmployee_EmployeeId");
            AddForeignKey("dbo.Commissions", "SellEmployee_EmployeeId", "dbo.Employees", "EmployeeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Commissions", "SellEmployee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.Commissions", new[] { "SellEmployee_EmployeeId" });
            DropColumn("dbo.Commissions", "SellEmployee_EmployeeId");
            DropColumn("dbo.Commissions", "SellComPercent");
        }
    }
}
