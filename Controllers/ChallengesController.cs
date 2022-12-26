using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcAlecScripts.Models;

namespace MvcAlecScripts.Controllers
{
    public class ChallengesController : Controller
    {
        public string controllerName = "Challenges";
        public IActionResult Index()
        {
            ViewData["title"] = "Home";
            ViewData["controller"] = controllerName;

            var viewModel = new ChallengesModel
            {
                

            };

            return View(viewModel);
        }
    }
}