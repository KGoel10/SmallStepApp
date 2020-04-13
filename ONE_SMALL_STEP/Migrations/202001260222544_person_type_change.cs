namespace ONE_SMALL_STEP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class person_type_change : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.PersonType", name: "PersonTypeName", newName: "PersonType");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.PersonType", name: "PersonType", newName: "PersonTypeName");
        }
    }
}
