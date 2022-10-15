<<<<<<< Updated upstream
using Domain.Dtos;
=======
>>>>>>> Stashed changes
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

<<<<<<< Updated upstream
public class EmployeeController:Controller
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }
    
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var employees = await _employeeService.GetEmployees();
        return View(employees);
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(AddEmployeeDto employee)
    {
        await _employeeService.CreateEmployee(employee);
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var employee = await _employeeService.GetEmployee(id);
        return View(employee);
    }
    [HttpPost]
    public async Task<IActionResult> Update(UpdateEmployeeDto employee)
    {
        await _employeeService.UpdateEmployee(employee);
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        await _employeeService.DeleteEmployee(id);
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public async Task<IActionResult> Details(int id)
    {
        var employee = await _employeeService.GetEmployee(id);
        return View(employee);
    }

}
=======

public class EmployeeController : Controller            
{
    private readonly IEmployeeService _challengeService;

    public EmployeeController(IEmployeeService challengeService)
    {
        _challengeService = challengeService;
    }

    [HttpGet]
    public async Task<IActionResult> GetEmployeeWithDepartmentDto()
    {
        var challenges = await _challengeService.GetEmployeeWithDepartmentDto();
        return View(challenges);
    }
    
    // [HttpPost]
    // public async Task<IActionResult> Post(GetEmployeeDto model)
    // {
    //     var newEmployee = await _challengeService.AddEmployee(model);
    //     return View(newEmployee);
    // }
    
   
}
>>>>>>> Stashed changes
