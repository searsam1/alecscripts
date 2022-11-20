using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class CppController : Controller
    {
        // GET: /Python/
    public string controllerName = "C++";
    public IActionResult Index()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Home";
        return View();
    }

    public IActionResult CPPversionHistory()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Cppversion History";
        return View();
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
      
    public IActionResult UserInput()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "User Input";
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
    
    public IActionResult AssignmentOperators()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Assignment Operators";
        return View();
    }
    
    public IActionResult ComparisonOperators()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Comparison Operators";
        return View();
    }
    
    public IActionResult Strings()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Strings";
        return View();
    }
    
    public IActionResult Math()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Math";
        return View();
    }
    
    public IActionResult Booleans()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Booleans";
        return View();
    }
    
    public IActionResult Conditions()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Conditions";
        return View();
    }
    
    public IActionResult TernaryOperator()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Ternary Operator";
        return View();
    }
    
    public IActionResult SwitchStatement()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Switch Statement";
        return View();
    }
    
    public IActionResult WhileLoop()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "While Loop";
        return View();
    }
    
    public IActionResult ForLoop()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "For Loop";
        return View();
    }
    
    public IActionResult BreakAndContinue()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Break And Continue";
        return View();
    }
    
    public IActionResult Arrays()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Arrays";
        return View();
    }
    
    public IActionResult Structures()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Structures";
        return View();
    }
    
    public IActionResult References()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "References";
        return View();
    }
    
    }
}