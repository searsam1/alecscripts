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
        return View();
    }

    public IActionResult PythonComments()
    {
        ViewData["controller"] = controllerName;
        return View();
    }

    public IActionResult PythonSyntax()
    {
        ViewData["controller"] = controllerName;
        return View();
    }
    public IActionResult PythonVariablesNames()
    {
        ViewData["controller"] = controllerName;
        return View();
    }
    public IActionResult PythonVariablesValues()
    {
        ViewData["controller"] = controllerName;
        return View();
    }
    public IActionResult PythonVariablesOutput()
    {
        ViewData["controller"] = controllerName;
        return View();
    }
    public IActionResult PythonVariablesGlobals()
    {
        ViewData["controller"] = controllerName;
        return View();
    }
    public IActionResult PythonDataTypes()
    {
        ViewData["controller"] = controllerName;
        return View();
    }
    public IActionResult PythonNumbers()
    {
        ViewData["controller"] = controllerName;
        return View();
    }
    // make an api
    // public IActionResult cg()
    // {
    //     return View("controllerGetter");
    // }

    }
}