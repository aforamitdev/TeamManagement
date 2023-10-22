using Contracts;
using Entities;

namespace Repository;

public class EmployeeRepository:RepositoryBase<Company>,IEmployeeRepository
{

    public EmployeeRepository(RepositoryContext repositoryContext):base(repositoryContext)
    {
        
    }
}