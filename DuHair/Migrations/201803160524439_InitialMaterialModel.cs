namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMaterialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaterialModels",
                c => new
                    {
                        MaterialID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        NetWeight = c.Int(nullable: false),
                        Unit = c.String(),
                        TimeOfUse = c.Int(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.MaterialID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MaterialModels");
        }
    }
}
