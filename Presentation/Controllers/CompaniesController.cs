using Entities.Exceptions;
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
            var companies = _service.CompanyService.GetAllCompanies(trackChanges: false);
            return Ok(companies);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetCompany(Guid id)
    {
        var company = _service.CompanyService.GetCompany(id, trackChanges: false);
        if (company is null)
            throw new CompanyNotFoundException(id);

        return Ok(company);
    }

   

}