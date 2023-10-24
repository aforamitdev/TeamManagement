namespace Entities.Exceptions;

public class CompanyNotFoundException:NotFoundException
{
    public CompanyNotFoundException(Guid id):base($"This company with id :{id} doesn't exist in the base"){
    }

}