using HotelB.Service;
using Microsoft.AspNetCore.Mvc;

namespace HotelB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IUserService _userServices;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IUserService userServices)
        {
            _logger = logger;
            _userServices = userServices;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet("GetUser/{id:int}")]
        public async Task<ActionResult> GetUserById(int id)
        {
            return Ok(await _userServices.GetUser(id));
        }


    }
}