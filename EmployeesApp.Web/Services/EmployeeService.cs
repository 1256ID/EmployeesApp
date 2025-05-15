using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services
{
    public class EmployeeService
    {
        private List<Employee> employees = [];
        private int nextId = 0;

        public int NextId { get => nextId++; set => nextId = value; }

        public void Add(Employee employee) {
            employee.Id = NextId;
            employees.Add(employee); 
        }
        public Employee[] GetAll() => employees.ToArray();
        public Employee? GetById(int id) => employees.SingleOrDefault(c => c.Id.Equals(id));
    }
}
