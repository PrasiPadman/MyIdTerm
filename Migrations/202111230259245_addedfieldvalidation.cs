namespace ExpITMidTerm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedfieldvalidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "CourseName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "CourseName", c => c.String());
        }
    }
}
