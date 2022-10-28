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
        public string controllerName = "Dotnet";
        public IActionResult Index()
        {
            ViewData["controller"] = controllerName;
            return View();
        }

        public IActionResult randomNumber(){
            ViewData["controller"] = controllerName;
            return View();
        }
    }
}