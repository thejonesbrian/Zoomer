using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zoomer.Models
{
    public class MinAgeToDriveCarWithLicense : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.Birthdate == null)
                return new ValidationResult("Birth date is required.");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;
            return (age > 15 || age == 15) ? ValidationResult.Success : new ValidationResult("Customer is to young to hold a license and can not drive.");
        }
    }
}