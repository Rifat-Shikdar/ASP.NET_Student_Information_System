namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendences",
                c => new
                    {
                        AttendenceId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.AttendenceId)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Grade = c.String(),
                        Age = c.Int(nullable: false),
                        Address = c.String(),
                        ParentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Parents", t => t.ParentId, cascadeDelete: true)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        ParentId = c.Int(nullable: false, identity: true),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ParentId);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        ScheduleId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        ClassName = c.String(),
                        ClassTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.ScheduleId)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.StudentRecords",
                c => new
                    {
                        StudentRecordId = c.Int(nullable: false, identity: true),
                        StudentRecordFileName = c.String(),
                        StudentRecordUploadedBy = c.Int(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.StudentRecordId)
                .ForeignKey("dbo.Users", t => t.StudentRecordUploadedBy, cascadeDelete: true)
                .Index(t => t.StudentRecordUploadedBy);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentRecords", "StudentRecordUploadedBy", "dbo.Users");
            DropForeignKey("dbo.Attendences", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Schedules", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "ParentId", "dbo.Parents");
            DropIndex("dbo.StudentRecords", new[] { "StudentRecordUploadedBy" });
            DropIndex("dbo.Schedules", new[] { "StudentId" });
            DropIndex("dbo.Students", new[] { "ParentId" });
            DropIndex("dbo.Attendences", new[] { "StudentId" });
            DropTable("dbo.Users");
            DropTable("dbo.StudentRecords");
            DropTable("dbo.Schedules");
            DropTable("dbo.Parents");
            DropTable("dbo.Students");
            DropTable("dbo.Attendences");
        }
    }
}
