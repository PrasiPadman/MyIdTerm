namespace ExpITMidTerm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changestatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "CourseRating", c => c.Int(nullable: false));
            DropColumn("dbo.Courses", "CourseRatin");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "CourseRatin", c => c.Int(nullable: false));
            DropColumn("dbo.Courses", "CourseRating");
        }
    }
}
