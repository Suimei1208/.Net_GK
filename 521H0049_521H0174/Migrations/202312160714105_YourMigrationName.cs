namespace _521H0049_521H0174.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YourMigrationName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Certificates", "IssuanceDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Certificates", "IssuanceDate");
        }
    }
}
