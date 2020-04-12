using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationinMVCLooslyBinding.Models
{
 


    public class NikhilCustomrValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string Message = value.ToString();
                if (Message.Contains("nikhil"))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Please Type Nikhil ! Come From CustomeValidationAttribute");
        }
    }
}