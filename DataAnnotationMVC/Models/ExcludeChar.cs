using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DataAnnotationMVC.Models
{
    public class ExcludeChar : ValidationAttribute,IClientValidatable
    {
        private readonly string _chars;

        public ExcludeChar(string chars)
            : base("{0} contains invalid character") // adding error message to base class
        {
            _chars = chars;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string Orgval = Convert.ToString(value);
            if (value != null)
            {
                foreach (char val in _chars)
                {
                    if (Orgval.Contains(val))
                    {
                        string ErrorMs = FormatErrorMessage(validationContext.DisplayName);
                        //validationContext.DisplayName= Display name of property
                        //FormatErrorMessage is used to add the DisplayName to the orignal error message.Replacing {0}

                        return new ValidationResult(ErrorMs);
                    }

                }
                //var ErrorMsg = FormatErrorMessage(validationContext.DisplayName);

                //return new ValidationResult(ErrorMessage);
            }
            return ValidationResult.Success;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            ModelClientValidationRule rule = new ModelClientValidationRule();
            rule.ValidationType = "exclude";
            rule.ErrorMessage = FormatErrorMessage(metadata.GetDisplayName());
            rule.ValidationParameters.Add("exchar", _chars);
            yield return rule;
        }

    }
}