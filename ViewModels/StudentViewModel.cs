using ExpITMidTerm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpITMidTerm.ViewModels
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public List<Course> CourseList { get; set; }
        

        //public static implicit operator StudentViewModel(StudentViewModel v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}