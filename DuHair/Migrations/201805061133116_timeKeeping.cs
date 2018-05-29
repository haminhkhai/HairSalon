namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class timeKeeping : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TimeKeepings",
                c => new
                    {
                        TimeKeepingId = c.Int(nullable: false, identity: true),
                        MonthAndYear = c.String(),
                        WorkingDay = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TimeKeepingId);
            
            CreateTable(
                "dbo.TKdetails",
                c => new
                    {
                        TKdetailId = c.Int(nullable: false, identity: true),
                        WorkedDay = c.Single(nullable: false),
                        Employee_EmployeeId = c.Int(),
                        TimeKeeping_TimeKeepingId = c.Int(),
                    })
                .PrimaryKey(t => t.TKdetailId)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeId)
                .ForeignKey("dbo.TimeKeepings", t => t.TimeKeeping_TimeKeepingId)
                .Index(t => t.Employee_EmployeeId)
                .Index(t => t.TimeKeeping_TimeKeepingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TKdetails", "TimeKeeping_TimeKeepingId", "dbo.TimeKeepings");
            DropForeignKey("dbo.TKdetails", "Employee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.TKdetails", new[] { "TimeKeeping_TimeKeepingId" });
            DropIndex("dbo.TKdetails", new[] { "Employee_EmployeeId" });
            DropTable("dbo.TKdetails");
            DropTable("dbo.TimeKeepings");
        }
    }
}
