// using System;
// using System.Security.Cryptography;
// using System.Text;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    
    public class DotnetController : Controller
    {
        public string controllerName = ".NET";
        public IActionResult Index()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Home";
            return View();
        }

        public IActionResult RandomNumber(){
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Random Number";
            return View();
        }
    public IActionResult RazorPages()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Razor Pages";
        return View();
    }
    
    public IActionResult GetStarted()
    {   
        ViewData["creationDate"] = "Wed Dec 28 09:17:45 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Get Started";
        return View();
    }
    
    public IActionResult AddController()
    {   
        ViewData["creationDate"] = "Wed Dec 28 09:41:40 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Add Controller";
        return View();
    }
    
    }
}