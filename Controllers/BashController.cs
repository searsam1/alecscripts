using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class BashController : Controller
    {
        // GET: /Python/
        
    public string controllerName = "Bash";
    public IActionResult Index()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Home";
        return View();
    }

    public IActionResult Variables()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Variables";
        return View();
    }

    public IActionResult PrintVariables()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Print Variables";
        return View();
    }

    public IActionResult Bashrc()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Bashrc";
        return View();
    }
    

    
    public IActionResult PromptExpansion()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Prompt Expansion";
        return View();
    }
    
    }
}