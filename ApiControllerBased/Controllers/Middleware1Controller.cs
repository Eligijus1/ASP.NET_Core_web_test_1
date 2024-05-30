using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApiControllerBased.Controllers
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

        [HttpGet(Name = "GetMiddleware1AboutInformation")]
        public string Get()
        {
            this._logger.LogInformation("{Date} {Time} UTC MIDDLEWARE_1_CONTROLLER_GET_START. Process ID: {ProcessId}. Used {RAM} bytes of RAM.",
                DateTime.UtcNow.ToShortDateString(),
                DateTime.UtcNow.ToLongTimeString(),
                Process.GetCurrentProcess().Id,
                GC.GetTotalMemory(true)
            );

            return "Middleware1Controller GET v2024-05-30";
        }

        /*
        // GET: Middleware1Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Middleware1Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Middleware1Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Middleware1Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: Middleware1Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Middleware1Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Middleware1Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */
    }
}
