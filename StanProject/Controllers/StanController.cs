using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StanProject.Controllers
{
    public class StanController : Controller
    {
        private readonly ILogger<StanController> _logger;
        public StanController(ILogger<StanController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            this._logger.LogWarning("This is StanController-Index");

            base.ViewBag.User1 = "User1";
            base.ViewData["User2"] = "User2";
            base.TempData["User3"] = "User3";

            string result = base.HttpContext.Session.GetString("User4");
            if (string.IsNullOrWhiteSpace(result))
            {
                base.HttpContext.Session.SetString("User4", "User4");
            }
            object name = "stan";

            return View(name);
        }
    }
}
