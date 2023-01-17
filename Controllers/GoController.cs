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
    
    public IActionResult Comments()
    {   
        ViewData["creationDate"] = "Tue Jan 17 01:17:56 2023 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Comments";
        return View();
    }
    
    public IActionResult Variables()
    {   
        ViewData["creationDate"] = "Tue Jan 17 01:28:14 2023 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Variables";
        return View();
    }
    
    }
}