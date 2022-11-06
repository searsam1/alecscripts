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
        ViewBag.py = PythonLinks.getLinks();
        return View();
    }

    public IActionResult CPPVersionHistory()
    {   
        ViewData["controller"] = controllerName;
        ViewBag.py = PythonLinks.getLinks();
        return View();
    }
      
    }
}