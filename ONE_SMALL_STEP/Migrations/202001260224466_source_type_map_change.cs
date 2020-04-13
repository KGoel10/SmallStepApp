namespace ONE_SMALL_STEP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class source_type_map_change : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.SourceType", name: "SourceTypeName", newName: "SourceType");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.SourceType", name: "SourceType", newName: "SourceTypeName");
        }
    }
}
