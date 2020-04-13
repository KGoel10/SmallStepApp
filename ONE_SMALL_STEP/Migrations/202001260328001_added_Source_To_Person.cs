namespace ONE_SMALL_STEP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_Source_To_Person : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Person", "SourceID");
            AddForeignKey("dbo.Person", "SourceID", "dbo.Source", "SourceID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Person", "SourceID", "dbo.Source");
            DropIndex("dbo.Person", new[] { "SourceID" });
        }
    }
}
