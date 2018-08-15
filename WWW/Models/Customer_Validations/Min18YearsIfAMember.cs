using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.Owin.Security.Provider;

namespace WWW.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || 
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            if (age >= 120)
            {
                return new ValidationResult("Customer should not have more than 120 years old.");
            }
            if (age < 18)
            {
                return new ValidationResult("Customer should be at least 18 years old to go on a membership.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}