namespace ONE_SMALL_STEP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sourcetypemap : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SourceType", "SourceTypeName", c => c.String(nullable: false, maxLength: 30, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SourceType", "SourceTypeName", c => c.String());
        }
    }
}
