using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompaniesController:ControllerBase
{
    private readonly IServiceManager _service;

    public CompaniesController(IServiceManager services) => _service = services;

    [HttpGet]
    public IActionResult GetCompanies()
    {
        try
        {
            var companies = _service.CompanyService.GetAllCompanies(trackChanges: false);
            return Ok(companies);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, "Internal service error");
        }
        
    }
}