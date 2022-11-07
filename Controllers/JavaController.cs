using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcAlecScripts.Models;

namespace MvcAlecScripts.Controllers
{
    public class JavaController : Controller
    {
        public string controllerName = "Java";
        public IActionResult Index()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Home";
            var viewModel = new LanguageModel
            {
                Language = "Java",
                ReleaseDate = "May 23, 1995",
                Use = "high",
                Inventor = "James Gosling"

            };
            return View(viewModel);
        }
    }
}