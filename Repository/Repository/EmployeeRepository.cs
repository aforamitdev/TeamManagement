using Contracts;
using Entities;

namespace Repository;

public class EmployeeRepository:RepositoryBase<Employee>,IEmployRepository
{
    public EmployeeRepository(RepositoryContext repositoryContext):base(repositoryContext)
    {
    }
}