﻿namespace _521H0049_521H0174.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TenMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Certificates",
                c => new
                    {
                        CertificateID = c.Int(nullable: false, identity: true),
                        CertificateName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.CertificateID);
            
            CreateTable(
                "dbo.CertificateStudentLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        CertificateID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Certificates", t => t.CertificateID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.CertificateID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Age = c.Int(),
                        Gender = c.String(),
                        GPA = c.Double(nullable: false),
                        Status = c.String(),
                        PhoneNumber = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.LoginHistory",
                c => new
                    {
                        LoginHistoryID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(),
                        LoginTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.LoginHistoryID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        FullName = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 100),
                        Role = c.String(nullable: false, maxLength: 50),
                        Age = c.Int(),
                        PhoneNumber = c.String(maxLength: 20),
                        Status = c.String(maxLength: 20),
                        Avatar = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CertificateStudentLists", "StudentID", "dbo.Students");
            DropForeignKey("dbo.CertificateStudentLists", "CertificateID", "dbo.Certificates");
            DropIndex("dbo.CertificateStudentLists", new[] { "CertificateID" });
            DropIndex("dbo.CertificateStudentLists", new[] { "StudentID" });
            DropTable("dbo.Users");
            DropTable("dbo.LoginHistory");
            DropTable("dbo.Students");
            DropTable("dbo.CertificateStudentLists");
            DropTable("dbo.Certificates");
        }
    }
}
