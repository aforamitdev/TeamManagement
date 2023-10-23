using Contracts;
using Entities;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service;

public class CompanyService:ICompanyService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

     public CompanyService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository=repository;
        _logger = logger;
    }


     public IEnumerable<CompanyDto> GetAllCompanies(bool trackChanges)
     {
         try
         {
             var companies = _repository.Company.GetAllCompanies(trackChanges);
             var companiesDto=companies.Select(c=>new CompanyDto(c.Id,c.Name??"",String.Join("",c.Address,c.Country)));
             return companiesDto;
         }
         catch (Exception e)
         {
             _logger.LogError($"something went wrong in the {nameof(GetAllCompanies)} service method {e}");
             throw;
         }
     }
}