namespace _521H0049_521H0174.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YourInitialMigrationName : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Certificates", "StudentID", "dbo.Students");
            DropIndex("dbo.Certificates", new[] { "StudentID" });
            CreateTable(
                "dbo.CertificateStudentLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        CertificateID = c.Int(nullable: false),
                        IssuanceDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Certificates", t => t.CertificateID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.CertificateID);
            
            DropColumn("dbo.Certificates", "StudentID");
            DropColumn("dbo.Certificates", "IssuanceDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Certificates", "IssuanceDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Certificates", "StudentID", c => c.Int(nullable: false));
            DropForeignKey("dbo.CertificateStudentLists", "StudentID", "dbo.Students");
            DropForeignKey("dbo.CertificateStudentLists", "CertificateID", "dbo.Certificates");
            DropIndex("dbo.CertificateStudentLists", new[] { "CertificateID" });
            DropIndex("dbo.CertificateStudentLists", new[] { "StudentID" });
            DropTable("dbo.CertificateStudentLists");
            CreateIndex("dbo.Certificates", "StudentID");
            AddForeignKey("dbo.Certificates", "StudentID", "dbo.Students", "StudentID", cascadeDelete: true);
        }
    }
}
