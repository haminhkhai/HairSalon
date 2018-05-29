namespace DuHair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSpendNote : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SpendNotes",
                c => new
                    {
                        SpendNoteId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AmountMoney = c.Int(nullable: false),
                        Monthly = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SpendNoteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SpendNotes");
        }
    }
}
