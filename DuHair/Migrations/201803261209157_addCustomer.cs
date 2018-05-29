namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerModels",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Tel = c.String(nullable: false, maxLength: 100),
                        Birthday = c.DateTime(nullable: false),
                        Point = c.Int(nullable: false),
                        Status = c.String(),
                        Sex = c.String(nullable: false, maxLength: 10),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerModels");
        }
    }
}
