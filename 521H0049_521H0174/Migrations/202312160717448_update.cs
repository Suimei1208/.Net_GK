namespace _521H0049_521H0174.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Certificates", "StudentID", "dbo.Students");
            DropPrimaryKey("dbo.Students");
            AddColumn("dbo.Students", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Students", "StudentID", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Students", "Id");
            AddForeignKey("dbo.Certificates", "StudentID", "dbo.Students", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Certificates", "StudentID", "dbo.Students");
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "StudentID", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Students", "Id");
            AddPrimaryKey("dbo.Students", "StudentID");
            AddForeignKey("dbo.Certificates", "StudentID", "dbo.Students", "StudentID", cascadeDelete: true);
        }
    }
}
