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
        ViewBag.py = PythonLinks.getLinks();
        return View();
    }
      
    }
}