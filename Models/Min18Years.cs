using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpITMidTerm.Models
{
    public class Min18Years :ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var student = (Student)validationContext.ObjectInstance;
            var Age = DateTime.Today.Year - student.DateOfBirth.Value.Year;

            if (Age < 18)
                return new ValidationResult("Age must be greater than 18 years."); // For simplicity, calculate Age based on year only. Full Age calculation has to consider year, month and day.

            return ValidationResult.Success;
        }
    }
}