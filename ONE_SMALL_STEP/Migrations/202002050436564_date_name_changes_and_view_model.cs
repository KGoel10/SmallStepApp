namespace ONE_SMALL_STEP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class date_name_changes_and_view_model : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MessageType", "DateCreated", c => c.DateTime(nullable: false));
            DropColumn("dbo.MessageType", "CreatedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MessageType", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.MessageType", "DateCreated");
        }
    }
}
