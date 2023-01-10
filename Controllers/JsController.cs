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
    public IActionResult AlternateTableRows()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Alternate Table Rows";
        return View();
    }

    public IActionResult Classes()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Classes";
        return View();
    }
    
    public IActionResult MethodDefinitions()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Method Definitions";
        return View();
    }
    
    public IActionResult CreateFileSafeNames()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Create File Safe Names";
        return View();
    }
    
    public IActionResult Replace()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Replace";
        return View();
    }
    
    public IActionResult RegexExec()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Regex Exec";
        return View();
    }
    
    public IActionResult ArraySort()
    {   
        ViewData["creationDate"] = "Mon Jan  9 10:09:57 2023 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Array Sort";
        return View();
    }
    
    public IActionResult Output()
    {   
        ViewData["creationDate"] = "Mon Jan  9 16:06:14 2023 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Output";
        return View();
    }
    
    public IActionResult Statements()
    {   
        ViewData["creationDate"] = "Tue Jan 10 02:42:13 2023 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Statements";
        return View();
    }
    
    public IActionResult Syntax()
    {   
        ViewData["creationDate"] = "Tue Jan 10 03:24:55 2023 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Syntax";
        return View();
    }
    
    public IActionResult Comments()
    {   
        ViewData["creationDate"] = "Tue Jan 10 04:16:15 2023 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Comments";
        return View();
    }
    
    public IActionResult Variables()
    {   
        ViewData["creationDate"] = "Tue Jan 10 04:30:39 2023 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Variables";
        return View();
    }
    
    }
}