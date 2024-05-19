using Microsoft.AspNetCore.Mvc;

namespace ApiControllerBased.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase {
        private readonly ILogger<WeatherForecastController> _logger;

        public InfoController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAboutInformation")]
        public string Get()
        {
            this._logger.LogInformation("INFO_CONTROLLER_GET_START");

            return "Test API v2024-05-18";
        }
    }
}
