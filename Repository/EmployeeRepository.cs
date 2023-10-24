using Contracts;
using Entities;

namespace Repository;

public class EmployeeRepository:RepositoryBase<Employee>,IEmployeeRepository
{

    public EmployeeRepository(RepositoryContext repositoryContext):base(repositoryContext)
    {
        
    }
    public IEnumerable<Employee> GetEmployees(Guid companyId, bool trackChange) => FindByCondition(e => e.CompanyId.Equals(companyId), trackChange).OrderBy(e=>e.Name).ToList();

}