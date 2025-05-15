using EmployeesApp.Web.Services;
using EmployeesApp.Web.Models;
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
    [HttpGet("/create")]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost("/create")]
    public IActionResult Create(Employee employee)
    {
        if (!ModelState.IsValid) return View(employee);
      
            employees.Add(employee);
            return RedirectToAction(nameof(Index));
        
       
    }
    [HttpGet("/detail/{id}")]
    public IActionResult Detail(int id)
    {
        var employee = employees.GetById(id);
        if (employee == null) return NotFound();
        return View(employee);
    }

}
