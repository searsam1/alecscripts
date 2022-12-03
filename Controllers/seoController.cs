using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcAlecScripts.Controllers
{
    public class SeoController : Controller
    {
        public string controllerName = "Seo";
        public IActionResult Index()
        {
            
            ViewData["title"] = "Home";
            ViewData["controller"] = controllerName;
            return View();
        }
    
    public IActionResult HtmlTags()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Html Tags";
        return View();
    }

    }
}