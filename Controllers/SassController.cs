using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Linq;

namespace MvcAlecScripts.Controllers
{
    
    public class SassController : Controller
    {

        public string controllerName = "Sass";
        public IActionResult Index()
        {
            ViewData["controller"] = controllerName;
            return View();
        }
        public IActionResult Variables()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Variables";
            return View();
        }
    }
}