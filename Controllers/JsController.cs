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
        return View();
    }

    public IActionResult jsGetMonth()
    {
        ViewData["controller"] = controllerName;
        return View();
    }
    public IActionResult Expressions_and_operators()
    {
        ViewData["controller"] = controllerName;
        return View();
    }
    public IActionResult BinaryArraytoDecimal() 
    {
        ViewData["controller"] = controllerName;
        return View();
    }
    public IActionResult ToFixed() 
    {
        ViewData["controller"] = controllerName;
        return View();
    }
    public IActionResult Json()
    {
        ViewData["controller"] = controllerName;
        return View();
    }
    }
}