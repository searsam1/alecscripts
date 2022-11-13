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
    
    public IActionResult Comments()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Comments";
        return View();
    }
    
    public IActionResult Lowercase()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Lowercase";
        return View();
    }
    
    public IActionResult Uppercase()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Uppercase";
        return View();
    }
    
    public IActionResult StringLength()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "String Length";
        return View();
    }
    
    public IActionResult SplitString()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Split String";
        return View();
    }
    
    public IActionResult Substring()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Substring";
        return View();
    }
    
    public IActionResult AppendString()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Append String";
        return View();
    }
    
    }
}