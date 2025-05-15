using EmployeesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;


namespace EmployeesApp.Web.Controllers;

public class EmployeeController : Controller
{
    private static EmployeeService employees = new();

    [Route("")]
    public IActionResult Index()
    {
        return View(employees.GetAll());
    }

}
