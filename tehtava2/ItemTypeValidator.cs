using System.ComponentModel.DataAnnotations;

namespace tehtava2{
    public class ItemTypeValidator : ValidationAttribute {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            string ItemType = value as string;
            
            if (ItemType == "sword") {
                return ValidationResult.Success;
            } else if (ItemType == "bow") {
                return ValidationResult.Success;
            } else if (ItemType == "axe") {
                return ValidationResult.Success;
            } else {
                return new ValidationResult("Not a valid Item");
            }
        }
    }
}