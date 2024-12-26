using Contracts;
using LoggerService;
public static class ServiceExtension
{

	public static void ConfigureCors(this IServiceCollection services)
	{
		services.AddCors(opts =>
	   {

		   opts.AddPolicy("CorsPolicy", builder =>
		   {
			   builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
		   });

	   });
	}


	public static void ConfigureLoggerService(this IServiceCollection services)
	{
		services.AddSingleton<ILoggerManager, LoggerManager>();

	}



}