using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name = "Name", Prompt = "Enter a name")]
        public string? Name { get; set; }
        [Display(Name = "E-mail", Prompt = "Enter a E-mail")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }       

    }
}
