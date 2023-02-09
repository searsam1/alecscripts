// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
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
                InstructionsTitle = "Introduction Challenge",
                Subheader = "Return 'Hello world'",
                InstructionsInstructions = "Return the string hello world to pass the tests",
                Tags = "<Tags Go here>",
                HelpLinks = "Link1 Link2 Link3",
                InstructionsExamples = "`main() -> hello world`",
                InstructionsNotes = "### NA",
            };

            return View(viewModel);
        }
    }
}