namespace ONE_SMALL_STEP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsourceandsourcetype : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Source",
                c => new
                    {
                        SourceID = c.Int(nullable: false, identity: true),
                        SourceName = c.String(),
                        SourceTypeID = c.Int(nullable: false),
                        test = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SourceID)
                .ForeignKey("dbo.SourceType", t => t.SourceTypeID, cascadeDelete: true)
                .Index(t => t.SourceTypeID);
            
            CreateTable(
                "dbo.SourceType",
                c => new
                    {
                        SourceTypeID = c.Int(nullable: false, identity: true),
                        SourceTypeName = c.String(),
                    })
                .PrimaryKey(t => t.SourceTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Source", "SourceTypeID", "dbo.SourceType");
            DropIndex("dbo.Source", new[] { "SourceTypeID" });
            DropTable("dbo.SourceType");
            DropTable("dbo.Source");
        }
    }
}
