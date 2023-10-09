using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace TeamManagement.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController:ControllerBase
{

    private ILoggerManager _logger;

    public WeatherForecastController(ILoggerManager logger)
    {
        _logger = logger;
    }
    



    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<string> Get()
    {
        _logger.LogInfo("here is info message from our values controller.");
        
        return new string[] { "value1", "value2" };
    }
}