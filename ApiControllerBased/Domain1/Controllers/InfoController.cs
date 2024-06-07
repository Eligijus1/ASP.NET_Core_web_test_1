using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApiControllerBased.Domain1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {
        private readonly ILogger<InfoController> _logger;
        private readonly IConfiguration Configuration;

        public InfoController(ILogger<InfoController> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        [HttpGet(Name = "GetAboutInformation")]
        public string Get()
        {
            _logger.LogInformation("{Date} {Time} UTC INFO_CONTROLLER_GET_START. Process ID: {ProcessId}. Used {RAM} bytes of RAM. Environment version is {Version}. MyKey1 value is '{MyKey1}'.",
                DateTime.UtcNow.ToShortDateString(),
                DateTime.UtcNow.ToLongTimeString(),
                Process.GetCurrentProcess().Id,
                GC.GetTotalMemory(true),
                Environment.Version.ToString(),
                Configuration["MyKey1"]
            );

            return "Test API v2024-06-07";
        }
    }
}
