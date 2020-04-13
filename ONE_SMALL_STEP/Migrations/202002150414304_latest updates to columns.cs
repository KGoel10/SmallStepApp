namespace ONE_SMALL_STEP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class latestupdatestocolumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Message", "MessageName", c => c.String());
            AddColumn("dbo.Person", "DateCreated", c => c.DateTime(nullable: false));
            DropColumn("dbo.Person", "CreatedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Person", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Person", "DateCreated");
            DropColumn("dbo.Message", "MessageName");
        }
    }
}
