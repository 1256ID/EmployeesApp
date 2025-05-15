using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EmployeesApp.Web.Attribute;

public class ValidNameAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        Regex regex = new Regex(@"^[a-zA-Z\s\-]{2,50}$");
        if (value is string name && !string.IsNullOrWhiteSpace(name) && regex.IsMatch(name))
        {
            return ValidationResult.Success;
        }
        return new ValidationResult("Name is not valid");
    }
}


