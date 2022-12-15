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
    
    public IActionResult Functions()
    {   
        ViewData["creationDate"] = "Fri Dec  9 02:41:11 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Functions";
        return View();
    }
    
    public IActionResult Packages()
    {   
        ViewData["creationDate"] = "Fri Dec  9 05:46:51 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Packages";
        return View();
    }
    
    public IActionResult Io()
    {   
        ViewData["creationDate"] = "Fri Dec  9 06:37:01 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Io";
        return View();
    }
    
    public IActionResult Output()
    {   
        ViewData["creationDate"] = "Fri Dec  9 09:17:15 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Output";
        return View();
    }
    
    public IActionResult TypeCasting()
    {   
        ViewData["creationDate"] = "Fri Dec  9 15:59:16 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Type Casting";
        return View();
    }
    
    public IActionResult WhileLoops()
    {   
        ViewData["creationDate"] = "Fri Dec  9 16:15:29 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "While Loops";
        return View();
    }
    
    public IActionResult ForLoops()
    {   
        ViewData["creationDate"] = "Fri Dec  9 16:31:48 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "For Loops";
        return View();
    }
    
    public IActionResult SwitchStatements()
    {   
        ViewData["creationDate"] = "Fri Dec  9 20:35:47 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Switch Statements";
        return View();
    }
    
    public IActionResult Classes()
    {   
        ViewData["creationDate"] = "Sun Dec 11 08:36:01 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Classes";
        return View();
    }
    
    public IActionResult Modifiers()
    {   
        ViewData["creationDate"] = "Mon Dec 12 07:36:12 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Modifiers";
        return View();
    }
    
    public IActionResult Encapsulation()
    {   
        ViewData["creationDate"] = "Mon Dec 12 21:25:22 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Encapsulation";
        return View();
    }
    
    public IActionResult Inheritance()
    {   
        ViewData["creationDate"] = "Mon Dec 12 21:41:30 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Inheritance";
        return View();
    }
    
    public IActionResult Polymorphism()
    {   
        ViewData["creationDate"] = "Mon Dec 12 21:57:52 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Polymorphism";
        return View();
    }
    
    public IActionResult InnerClasses()
    {   
        ViewData["creationDate"] = "Tue Dec 13 00:00:38 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Inner Classes";
        return View();
    }
    
    public IActionResult Abstraction()
    {   
        ViewData["creationDate"] = "Tue Dec 13 00:24:55 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Abstraction";
        return View();
    }
    
    public IActionResult Enums()
    {   
        ViewData["creationDate"] = "Tue Dec 13 09:28:46 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Enums";
        return View();
    }
    
    public IActionResult UserInput()
    {   
        ViewData["creationDate"] = "Wed Dec 14 01:36:24 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "User Input";
        return View();
    }
    
    public IActionResult DateAndTime()
    {   
        ViewData["creationDate"] = "Wed Dec 14 02:22:36 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Date And Time";
        return View();
    }
    
    }
}