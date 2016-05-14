using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DataAnnotationMVC.Models
{
    public class CheckBoxValidtaion:ValidationAttribute,IClientValidatable
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

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {

            ModelClientValidationRule rule = new ModelClientValidationRule();
            rule.ValidationType = "checkbox";
            rule.ErrorMessage = FormatErrorMessage(metadata.GetDisplayName());
            rule.ValidationParameters.Add("check",true);

            yield return rule;
        }

    }
}