using Contracts;
using Service.Contracts;

namespace Service;

public sealed class ServiceManager
{
    private readonly Lazy<ICompanyService> _companyService;
    private readonly Lazy<IEmployeeService> _employeeService;
    
    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
    {
        _companyService = new Lazy<ICompanyService>(() => new CompanyService(repositoryManager,logger));
        _employeeService = new Lazy<IEmployeeService>(() => new EmployeeService(repositoryManager, logger));

    }
}
