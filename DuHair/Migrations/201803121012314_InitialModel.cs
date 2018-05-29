namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeModels",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Tel = c.String(),
                        Address = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        Wage = c.Int(nullable: false),
                        Status = c.String(),
                        Sex = c.Int(nullable: false),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmployeeModels");
        }
    }
}
