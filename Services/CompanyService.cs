﻿using AutoMapper;
using Contracts;
using Entities;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service;

public class CompanyService:ICompanyService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;
     public CompanyService(IRepositoryManager repository, ILoggerManager logger,IMapper mapper)
    {
        _repository=repository;
        _logger = logger;
        _mapper = mapper;
    }


     public IEnumerable<CompanyDto> GetAllCompanies(bool trackChanges)
     {
         try
         {
             var companies = _repository.Company.GetAllCompanies(trackChanges);

             var companiesDto = _mapper.Map<IEnumerable<CompanyDto>>(companies);
             return companiesDto;
         }
         catch (Exception e)
         {
             _logger.LogError($"something went wrong in the {nameof(GetAllCompanies)} service method {e}");
             throw;
         }
     }
}