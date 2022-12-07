using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyPro.MVC.Controllers
{
    public class SurveyController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("SurveyManagement", "Survey");
        }

        public IActionResult SurveyManagement()
        {
            return View();
        }

        public IActionResult SurveyEditor()
        {
            return View();
        }
    }
}