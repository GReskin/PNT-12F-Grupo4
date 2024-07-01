using System.ComponentModel.DataAnnotations;

namespace App.Validators
{
    public class FechaValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            value = (DateTime)value;
            if (DateTime.Now.AddYears(-100).CompareTo(value) <= 0 && DateTime.Now.CompareTo(value) >= 0)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Fechas validas: No anteriores a cien años ni posteriores a fecha actual");
            }
        }
    }
}
