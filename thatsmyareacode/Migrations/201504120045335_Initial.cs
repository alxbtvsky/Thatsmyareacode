namespace thatsmyareacode.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zingers",
                c => new
                    {
                        ZingerID = c.Int(nullable: false, identity: true),
                        ZingerMessage = c.String(),
                        ZingerImage = c.String(),
                        ZingerUserName = c.String(),
                        Genre = c.String(),
                        AreaCode = c.String(),
                        UpVote = c.Int(nullable: false),
                        DownVote = c.Int(nullable: false),
                        Favorite = c.Boolean(nullable: false),
                        TimeCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ZingerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Zingers");
        }
    }
}
