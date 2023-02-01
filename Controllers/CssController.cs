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
    
    public IActionResult Borders()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Borders";
        return View();
    }
    
    public IActionResult Margins()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Margins";
        return View();
    }
    
    public IActionResult Padding()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Padding";
        return View();
    }
    
    public IActionResult HeightAndWidth()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Height And Width";
        return View();
    }
    
    public IActionResult BoxModel()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Box Model";
        return View();
    }
    
    public IActionResult Outline()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Outline";
        return View();
    }
    
    public IActionResult Text()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Text";
        return View();
    }
    
    public IActionResult Fonts()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Fonts";
        return View();
    }
    
    public IActionResult Icons()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Icons";
        return View();
    }
    
    public IActionResult Links()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Links";
        return View();
    }
    
    public IActionResult Position()
    {   
        ViewData["creationDate"] = "Tue Jan 31 21:33:48 2023 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Position";
        return View();
    }
    
    }
}