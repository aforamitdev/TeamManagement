using NLog;


var builder = WebApplication.CreateBuilder(args);



// LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "./nlog.config"));

builder.Services.AddControllers();

builder.Services.ConfigureCors();
builder.Services.ConfigureLoggerService();

var app = builder.Build();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.Run(async context =>
{
	await context.Response.WriteAsync("Hello from the middleware component");
});

app.UseHttpsRedirection();

app.Run();
