using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcAlecScripts.Controllers
{
    public class v2Controller : Controller
    {
        public string controllerName = "v2";
        public IActionResult Index()
        {
            
            ViewData["title"] = "Home";
            ViewData["controller"] = controllerName;
            return View();
        }

        
    }
}