using ApiControllerBased.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApiControllerBased.Domain1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Domain1AController : ControllerBase
    {
        private readonly ILogger<Domain1AController> _logger;

        public Domain1AController(ILogger<Domain1AController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Domain1AControllerGet")]
        public string Get()
        {
            this._logger.LogInformation("{Date} {Time} UTC DOMAIN_1_A_CONTROLLER_GET_START. Process ID: {ProcessId}. Used {RAM} bytes of RAM.",
                DateTime.UtcNow.ToShortDateString(),
                DateTime.UtcNow.ToLongTimeString(),
                Process.GetCurrentProcess().Id,
                GC.GetTotalMemory(true)
            );

            return "Domain1AController GET done.";
        }
    }
}

