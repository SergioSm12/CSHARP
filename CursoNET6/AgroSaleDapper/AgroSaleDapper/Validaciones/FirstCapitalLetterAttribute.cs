using System.ComponentModel.DataAnnotations;

namespace AgroSaleDapper.Validaciones
{
    public class FirstCapitalLetterAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
             if(value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
             var firstCapitalLetter = value.ToString()[0].ToString();

            if(firstCapitalLetter != firstCapitalLetter.ToUpper())
            {
                return new ValidationResult("The first letter must be capitalized.");
            }

            return ValidationResult.Success;
        }
    }
}
