using Contracts;

namespace Repository;

public sealed class RepositoryManager:IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<ICompanyRepository> _companyRepository;
    private readonly Lazy<IEmployRepository> _employeeRepository;

    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
        _companyRepository=new Lazy<ICompanyRepository>(()=>new CompanyRepository(repositoryContext));
        _employeeRepository = new Lazy<IEmployRepository>(() => new EmployeeRepository(repositoryContext));

    }

    public ICompanyRepository Company => _companyRepository.Value;
    public IEmployRepository Employee => _employeeRepository.Value;
    public void Save() => _repositoryContext.SaveChanges();

}