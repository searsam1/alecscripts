using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcAlecScripts.Models;

namespace MvcMovie.Controllers
{
    public class PythonLinks {
        public static string getLinks(){
            return "s";
        }
        
    }
    
    public class PythonController : Controller
    {
        public string controllerName = "Python";

    public IActionResult Index()
    {
        ViewData["controller"] = controllerName;
        return View();
    }

    public IActionResult Password()
    {
        ViewData["controller"] = controllerName;
        return View();
    }

    public IActionResult swapcase()
    {
        ViewData["controller"] = controllerName;
        return View();
    }
    public IActionResult vars()
    {
        ViewData["controller"] = controllerName;
        return View();
    }
    
    public IActionResult abs()
    {
        ViewData["controller"] = controllerName;
        return View();
    }

    public IActionResult funnyNumbers()
    {
        ViewData["controller"] = controllerName;
        return View();
    }
    public IActionResult stringFormattingTypes()
    {
        ViewData["controller"] = controllerName;
        return View();
    }

    public IActionResult controllerGetter()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Controller Getter";
        return View();
    }

    public IActionResult Comments()
    {
        ViewData["controller"] = controllerName;
        return View();
    }

    public IActionResult Syntax()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Syntax";
        return View();
    }
    public IActionResult VariableNames()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Variable Names";
        
        return View();
    }
    public IActionResult VariableValues()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Variable Values";
        return View();
    }
    public IActionResult VariableOutput()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Variable Output";
        return View();
    }
    public IActionResult VariableGlobals()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Variable Globals";
        return View();
    }
    public IActionResult DataTypes()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Data Types";
        return View();
    }
    public IActionResult Numbers()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Numbers";
        return View();
    }
    public IActionResult Modules()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Modules";
        return View();
    }

    public IActionResult ReFlags()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Re Flags";
        return View();
    }

    public IActionResult Casting()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Casting";
        return View();
    }
    
    public IActionResult Classes()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Classes";
        return View();
    }
    
    public IActionResult Print()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Print";
        return View();
    }
    
    }
}