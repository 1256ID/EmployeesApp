using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name", Prompt = "Enter a name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Surname is required")]
        [Display(Name = "E-mail", Prompt = "Enter a E-mail")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }       

    }
}
