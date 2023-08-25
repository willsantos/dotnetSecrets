using Microsoft.AspNetCore.Mvc;

namespace Secrets.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IConfiguration _configuration;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    [HttpGet]
    public IEnumerable<string> GetVars()
    {
        var variaveis = new List<string>();
        
        variaveis.Add(_configuration["ConnectionStrings:Default"]);
        variaveis.Add(_configuration["JWT:UserKey"]);
        variaveis.Add(_configuration["JWT:ShopKey"]);

        return variaveis;
    }
}