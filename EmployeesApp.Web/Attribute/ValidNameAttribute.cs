using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Attribute;

public class ValidNameAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is string name && !string.IsNullOrWhiteSpace(name)&& !name.Contains('.'))
        {
            return ValidationResult.Success;
        }
        return new ValidationResult("Name is not valid");
    }
}


