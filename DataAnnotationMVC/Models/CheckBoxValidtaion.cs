using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationMVC.Models
{
    public class CheckBoxValidtaion:ValidationAttribute
    {
        public CheckBoxValidtaion():base("Please select checkbox")
        {
        
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                Convert.ToBoolean(value);
                if (!Convert.ToBoolean(value))
                {
                    return new ValidationResult(ErrorMessage);
                }
            }
            return ValidationResult.Success;
        }

    }
}