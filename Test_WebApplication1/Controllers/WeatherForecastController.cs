using Microsoft.AspNetCore.Mvc;

namespace Test_WebApplication1.Controllers
{
    [ApiController] // What is attribute.  What is Open API. What is swagger. Four Pillars of OOPS
    [Route("[controller]")] // What is Routing in Dotnet.
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[] // What is access modifiers? what is static? what is readonly?
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
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
        [httpget]
        [route("test1")]
        public string asshole()
        {
            return("kishan");    
        }
        [httpget]
        [route("test2")]
        public list<string> listtest()
        {
            list<string> alias = new list<string>(10);
            alias.add("kishan");
            alias.add("adi");
            alias.add("vik");
            alias.add("abhi");
            alias.add("chaman");
            return alias
            .tolist();
        }
    }
}