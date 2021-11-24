using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpITMidTerm.Models
{
    public class Student
    {
        
        [Required]
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
       
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Min18Years]
        public DateTime? DateOfBirth { get; set; }
        public Course Course { get; set; }

        [Required]
        [Display(Name = "Course ID")]
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Course Enrolled Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? CourseEnrolleddate { get; set; }

        [Required]
        [Display(Name = "Course Status")]
        public int CourseStatus { get; set; }

        [Required]
        [Display(Name = "Grade")]
        public string Grade { get; set; }
    }
}