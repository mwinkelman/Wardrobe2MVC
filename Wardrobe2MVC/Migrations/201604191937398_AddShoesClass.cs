namespace Wardrobe2MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShoesClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shoes",
                c => new
                    {
                        ShoeID = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        PhotoURL = c.String(),
                        Type = c.String(),
                        Color = c.String(),
                        Season = c.String(),
                        Occasion = c.String(),
                    })
                .PrimaryKey(t => t.ShoeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Shoes");
        }
    }
}
