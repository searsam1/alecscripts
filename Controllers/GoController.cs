// using System;
// using System.Security.Cryptography;
// using System.Text;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    
    public class GoController : Controller
    {
        public string controllerName = "Go";
        public IActionResult Index()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Home";
            return View();
        }
    public IActionResult PrintStatement()
    {   
        ViewData["creationDate"] = "Tue Dec 13 01:12:16 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Print Statement";
        return View();
    }
    
    }
}