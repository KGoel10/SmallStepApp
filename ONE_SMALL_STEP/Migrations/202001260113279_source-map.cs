namespace ONE_SMALL_STEP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sourcemap : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Source", "test");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Source", "test", c => c.Int(nullable: false));
        }
    }
}
