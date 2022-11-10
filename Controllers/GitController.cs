using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcAlecScripts.Controllers
{
    public class GitController : Controller
    {
        public IActionResult Index()
        {
            ViewData["title"] = "Home";
            ViewData["controller"] = "Git";

            return View();
        }
    }
}