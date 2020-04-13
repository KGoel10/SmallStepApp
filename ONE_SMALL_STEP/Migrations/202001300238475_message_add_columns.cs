namespace ONE_SMALL_STEP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class message_add_columns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Message", "MessageFileName", c => c.String());
            AddColumn("dbo.Message", "MessageLocation", c => c.String());
            AddColumn("dbo.Message", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Message", "DateUpdated", c => c.DateTime(nullable: false));
            DropColumn("dbo.Message", "CreatedDate");
            DropColumn("dbo.Message", "DummyCol");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Message", "DummyCol", c => c.Int(nullable: false));
            AddColumn("dbo.Message", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Message", "DateUpdated");
            DropColumn("dbo.Message", "DateCreated");
            DropColumn("dbo.Message", "MessageLocation");
            DropColumn("dbo.Message", "MessageFileName");
        }
    }
}
