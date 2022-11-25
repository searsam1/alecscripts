using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcAlecScripts.Controllers
{
    public class CssController : Controller
    {
        public string controllerName = "Css";
        public IActionResult Index()
        {
            ViewData["title"] = "Home";
            ViewData["controller"] = "Css";
            return View();
        }
    public IActionResult SlowUnderlineWithCss()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Slow Underline With Css";
        return View();
    }
    
    public IActionResult Gradients()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Gradients";
        return View();
    }
    
    public IActionResult Colors()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Colors";
        return View();
    }
    
    public IActionResult Comments()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Comments";
        return View();
    }
    
    public IActionResult Backgrounds()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Backgrounds";
        return View();
    }
    
    }
}