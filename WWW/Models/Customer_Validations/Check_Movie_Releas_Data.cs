using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WWW.Models.Customer_Validations
{
    public class Check_Movie_Releas_Data : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            var age = DateTime.Today.Year - movie.ReleaseDate.Value.Year;

            if (age >= 140)
                return new ValidationResult("Movie should not have more than 140 years old.");

                return ValidationResult.Success;
        }
    }
}