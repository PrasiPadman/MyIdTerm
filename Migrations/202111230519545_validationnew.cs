namespace ExpITMidTerm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validationnew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "CourseRatin", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Courses", "CourseDescription", c => c.String(nullable: false));
            AlterColumn("dbo.Courses", "TutorName", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Grade", c => c.String(nullable: false));
            DropColumn("dbo.Courses", "CourseRating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "CourseRating", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "Grade", c => c.String());
            AlterColumn("dbo.Courses", "TutorName", c => c.String());
            AlterColumn("dbo.Courses", "CourseDescription", c => c.String());
            DropColumn("dbo.Students", "DateOfBirth");
            DropColumn("dbo.Courses", "CourseRatin");
        }
    }
}
