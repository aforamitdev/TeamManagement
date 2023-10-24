using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace Presentation.Controllers;

[Route("/api/companies/{companyId}/employees")]
[ApiController]
public class EmployeesController:ControllerBase
{
     private readonly IServiceManager _service;

     public EmployeesController(IServiceManager services) => _service = services;
     
     [HttpGet]
     public IActionResult GetEmployeesForCompany(Guid companyId)
     {
          var employees = _service.EmployeeService.GetEmployees(companyId, trackChanges: false);
          return Ok(employees);
     }
}