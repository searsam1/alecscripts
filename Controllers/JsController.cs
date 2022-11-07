using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Linq;

namespace MvcMovie.Controllers
{
    
    public class JsController : Controller
    {
        public string controllerName = "Js";

    public string DreamWorldCoke(){
        return @"
        
{
    ""Dream-Word-Coke"" : {
        ""Total-Fat"" : ""0g"",
        ""Sodium"" : ""50mg""
    }
}";
    }
    public IActionResult Index()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Home";
        return View();
    }

    public IActionResult GetMonth()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Get Month";
        
        return View();
    }
    public IActionResult ExpressionsOperators()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Expressions Operators";
        return View();
    }
    public IActionResult BinaryArrayToDecimal() 
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Binary Array To Decimal";
        return View();
    }
    public IActionResult ToFixed() 
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "To Fixed";
        return View();
    }
    public IActionResult Json()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Json";
        return View();
    }
    public IActionResult RandomColorCreater()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Random Color Creater";
        return View();
    }
    }
}