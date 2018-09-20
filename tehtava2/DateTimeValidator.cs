using System;
using System.ComponentModel.DataAnnotations;

namespace tehtava2
{
    public class DateTimeValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            DateTime time = (DateTime)value;
            if (time < System.DateTime.Now) {
                return ValidationResult.Success;
            } else {
                return new ValidationResult("Error with DateTime");
            }
        }
    }
}