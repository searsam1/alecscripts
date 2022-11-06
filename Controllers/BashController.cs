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
        return View();
    }

    public IActionResult BashVariables()
    {   
        ViewData["controller"] = controllerName;
        return View();
    }
      
    }
}