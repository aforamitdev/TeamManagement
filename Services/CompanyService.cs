﻿using Contracts;
using Entities;
using Service.Contracts;

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


     public IEnumerable<Company> GetAllCompanies(bool trackChanges)
     {
         try
         {
             var companies = _repository.Company.GetAllCompanies(trackChanges);
             return companies;
         }
         catch (Exception e)
         {
             _logger.LogError($"something went wrong in the {nameof(GetAllCompanies)} service method {e}");
             throw;
         }
     }
}