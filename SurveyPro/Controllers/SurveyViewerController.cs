using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SurveyPro.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyPro.Controllers
{
    public class SurveyViewerController : Controller
    {
        private readonly ILogger<SurveyViewerController> _logger;

        public SurveyViewerController(ILogger<SurveyViewerController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
