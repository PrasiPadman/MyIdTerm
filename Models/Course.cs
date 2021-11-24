using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ExpITMidTerm.Models
{
    public class Course
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public String CourseName { get; set; }
        [Required]
        public string CourseDescription { get; set; }
        [Required]
        public string TutorName { get; set; }
        [Required]
        [Range(1, 10, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int CourseRating { get; set; }
    }
}