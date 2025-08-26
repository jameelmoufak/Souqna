using System.ComponentModel.DataAnnotations;

namespace Souqna.Data.Attributes
{
    public class Min18YearsOldAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateOnly birthday)
            {
                var today = DateOnly.FromDateTime(DateTime.Today);
                var age = today.Year - birthday.Year;
                if (birthday > today.AddYears(-age)) age--;
                if (age < 18)
                {
                    return new ValidationResult(ErrorMessage ?? "You must be at least 18 years old");
                }
            }
            return ValidationResult.Success;
        }
    }
}
