namespace Wardrobe2MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shirts",
                c => new
                    {
                        TopID = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        PhotoURL = c.String(),
                        Type = c.String(),
                        Color = c.String(),
                        Season = c.String(),
                        Occasion = c.String(),
                    })
                .PrimaryKey(t => t.TopID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Shirts");
        }
    }
}
