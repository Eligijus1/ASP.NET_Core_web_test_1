using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApiControllerBased.Domain1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Middleware1Controller : ControllerBase
    {
        private readonly ILogger<Middleware1Controller> _logger;

        public Middleware1Controller(ILogger<Middleware1Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetMiddleware1")]
        public string Get()
        {
            _logger.LogInformation("{Date} {Time} UTC MIDDLEWARE_1_CONTROLLER_GET_START. Process ID: {ProcessId}. Used {RAM} bytes of RAM.",
                DateTime.UtcNow.ToShortDateString(),
                DateTime.UtcNow.ToLongTimeString(),
                Process.GetCurrentProcess().Id,
                GC.GetTotalMemory(true)
            );

            return "Middleware1Controller GET done";
        }

        [HttpPost(Name = "PostMiddleware1")]
        public string Post(string parameter1, string parameter2, string parameter3)
        {
            _logger.LogInformation("{Date} {Time} UTC MIDDLEWARE_1_CONTROLLER_POST_START. Process ID: {ProcessId}. Used {RAM} bytes of RAM. parameter1={parameter1}. parameter2={parameter2}. parameter3={parameter3}",
                DateTime.UtcNow.ToShortDateString(),
                DateTime.UtcNow.ToLongTimeString(),
                Process.GetCurrentProcess().Id,
                GC.GetTotalMemory(true),
                parameter1,
                parameter2,
                parameter3
            );

            return "Middleware1Controller POST done.";
        }

        [HttpDelete(Name = "DeleteMiddleware1")]
        public string Delete(int parameter1)
        {
            _logger.LogInformation("{Date} {Time} UTC MIDDLEWARE_1_CONTROLLER_DELETE_START. Process ID: {ProcessId}. Used {RAM} bytes of RAM. parameter1={parameter1}.",
                DateTime.UtcNow.ToShortDateString(),
                DateTime.UtcNow.ToLongTimeString(),
                Process.GetCurrentProcess().Id,
                GC.GetTotalMemory(true),
                parameter1
            );

            return "Middleware1Controller DELETE done.";
        }
    }
}
