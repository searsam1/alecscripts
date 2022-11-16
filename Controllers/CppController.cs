using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class CppController : Controller
    {
        // GET: /Python/
    public string controllerName = "Cpp";
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
    
    }
}