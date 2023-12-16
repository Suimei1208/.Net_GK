namespace _521H0049_521H0174.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YourMigrationName8 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CertificateStudentLists", "IssuanceDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CertificateStudentLists", "IssuanceDate", c => c.DateTime(nullable: false));
        }
    }
}
