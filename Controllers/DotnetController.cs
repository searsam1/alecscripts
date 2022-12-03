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
    
    }
}