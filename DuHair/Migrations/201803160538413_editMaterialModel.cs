namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editMaterialModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MaterialModels", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MaterialModels", "ImageUrl");
        }
    }
}
