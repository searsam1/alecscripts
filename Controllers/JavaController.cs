using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcAlecScripts.Models;

namespace MvcAlecScripts.Controllers
{
    public class JavaController : Controller
    {
        public string controllerName = "Java";
        public IActionResult Index()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Home";
            var viewModel = new LanguageModel
            {
                Language = "Java",
                ReleaseDate = "May 23, 1995",
                Use = "high",
                Inventor = "James Gosling"

            };
            return View(viewModel);
        }

    
    
    public IActionResult Comments()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Comments";
        return View();
    }
    
    public IActionResult Variables()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Variables";
        return View();
    }
    
    public IActionResult Math()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Math";
        return View();
    }
    
    public IActionResult DataTypes()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Data Types";
        return View();
    }
    
    public IActionResult Operators()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Operators";
        return View();
    }
    
    public IActionResult Arrays()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Arrays";
        return View();
    }
    
    public IActionResult Strings()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Strings";
        return View();
    }
    
    public IActionResult ControlFlow()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Control Flow";
        return View();
    }
    
    }
}