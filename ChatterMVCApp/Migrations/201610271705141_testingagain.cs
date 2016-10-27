namespace ChatterMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testingagain : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MessageModels",
                c => new
                    {
                        MessageID = c.Int(nullable: false, identity: true),
                        MessageText = c.String(maxLength: 150),
                        MessageTimeStamp = c.DateTime(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MessageID)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MessageModels", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.MessageModels", new[] { "ApplicationUser_Id" });
            DropTable("dbo.MessageModels");
        }
    }
}
