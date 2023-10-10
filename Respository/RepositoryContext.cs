using Entities;
using Microsoft.EntityFrameworkCore;

namespace Respository;

public class RepositoryContext:DbContext
{
    public RepositoryContext(DbContextOptions options):base(options)
    {
        
    }

    public DbSet<Company>? Companies { get; set; }
    public DbSet<Employee>? Employees { get; set; }

}