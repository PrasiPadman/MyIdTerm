using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExpITMidTerm.Models
{
    public class ExpITMidTermcontext : DbContext
    {
        public ExpITMidTermcontext(): base("name=ExpItMidTermContext")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        //public DbSet<Coursestatus> CourseStatuses { get; set; }
    }
}