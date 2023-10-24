using Entities.Exceptions;

namespace EmployeeManagement.Extensions;

public class EmployeeNotFoundException:NotFoundException
{
    public EmployeeNotFoundException(Guid employeeId):base($"$Employee with id:{employeeId} doesn't exists in the database.")
    {

    }
}