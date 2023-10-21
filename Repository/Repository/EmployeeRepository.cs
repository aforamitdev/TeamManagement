using Contracts;
using Entities;
using Repository;


public class EmployeeRepository:RepositoryBase<Employee>,IEmployRepository
{
    public EmployeeRepository(RepositoryContext repositoryContext):base(repositoryContext)
    {
    }
}