namespace _521H0049_521H0174.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YourMigrationName6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Students", "LastName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
