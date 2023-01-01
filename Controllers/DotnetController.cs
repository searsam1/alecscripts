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
    
    public IActionResult AddViews()
    {   
        ViewData["creationDate"] = "Thu Dec 29 05:33:23 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Add Views";
        return View();
    }
    
    public IActionResult AddModel()
    {   
        ViewData["creationDate"] = "Fri Dec 30 08:03:45 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Add Model";
        return View();
    }
    
    public IActionResult WorkWithADatabase()
    {   
        ViewData["creationDate"] = "Fri Dec 30 14:15:06 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Work With A Database";
        return View();
    }
    
    
    }
}