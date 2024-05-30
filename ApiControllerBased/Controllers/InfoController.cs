using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApiControllerBased.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {
        private readonly ILogger<InfoController> _logger;

        public InfoController(ILogger<InfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAboutInformation")]
        public string Get()
        {
            this._logger.LogInformation("{Date} {Time} UTC INFO_CONTROLLER_GET_START. Process ID: {ProcessId}. Used {RAM} bytes of RAM.",
                DateTime.UtcNow.ToShortDateString(),
                DateTime.UtcNow.ToLongTimeString(),
                Process.GetCurrentProcess().Id,
                GC.GetTotalMemory(true)
            );

            return "Test API v2024-05-30";
        }
    }
}
