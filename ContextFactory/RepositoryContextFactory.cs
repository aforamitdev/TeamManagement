using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repository;

namespace CompanyEmployee.ContextFactory;

public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
{

	public RepositoryContext CreateDbContext(string[] args)
	{

		var configurations = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

		var builder = new DbContextOptionsBuilder<RepositoryContext>().UseSqlServer(configurations.GetConnectionString("sqlConnection"));
		return new RepositoryContext(builder.Options);

	}

}
