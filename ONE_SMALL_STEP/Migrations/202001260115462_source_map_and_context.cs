namespace ONE_SMALL_STEP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class source_map_and_context : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Source", name: "SourceName", newName: "Source");
            AlterColumn("dbo.Source", "Source", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Source", "Source", c => c.String());
            RenameColumn(table: "dbo.Source", name: "Source", newName: "SourceName");
        }
    }
}
