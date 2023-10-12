namespace Contracts;

public interface IRepositoryManager
{
    ICompanyRepository Company { get; }
    IEmployRepository Employee { get; }
    void Save();
}
