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
      
    }
}