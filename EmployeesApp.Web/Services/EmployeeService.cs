using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services
{
    public class EmployeeService
    {
        private List<Employee> employees = [];

        public void Add(Employee employee) => employees.Add(employee);
        public Employee[] GetAll() => employees.ToArray();
        public Employee? GetById(int id) => employees.SingleOrDefault(c => c.Id.Equals(id));
    }
}
