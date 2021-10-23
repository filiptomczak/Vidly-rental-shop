using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.DTOs;

namespace Vidly.Models
{
    public class MembershipAgeValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == MembershipTypes.Unknown || customer.MembershipTypeId == MembershipTypes.Monthly)
                return ValidationResult.Success;
            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required");
            if (DateTime.Today.Year - customer.Birthdate.Value.Year >= 18)
                return ValidationResult.Success;
            else
                return new ValidationResult("Customer must be over 18 to get Membership Type");
        }
    }
}