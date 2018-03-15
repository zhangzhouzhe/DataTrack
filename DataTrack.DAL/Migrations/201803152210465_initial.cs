namespace DataTrack.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sources",
                c => new
                    {
                        Key = c.Int(nullable: false, identity: true),
                        Location = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => t.Key);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sources");
        }
    }
}
