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
         
             var companies = _repository.Company.GetAllCompanies(trackChanges);

             var companiesDto = _mapper.Map<IEnumerable<CompanyDto>>(companies);
             return companiesDto;
        
     }
     public CompanyDto GetCompany(Guid companyId, bool trackChanges)
     {
         var company = _repository.Company.GetCompany(companyId, trackChanges);
         var companyDto = _mapper.Map<CompanyDto>(company);
         return companyDto;
     }
     public CompanyDto CreateCompany(CompanyForCreateDto company)
     {
         var companyEntity = _mapper.Map<Company>(company);
         _repository.Company.CreateCompany(companyEntity);
         _repository.Save();

    Console.Write(company);
         
         var companyToReturn = _mapper.Map<CompanyDto>(companyEntity);
         return companyToReturn;
     }
}