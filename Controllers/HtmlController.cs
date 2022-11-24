using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HtmlController : Controller
    {
        // GET: /Python/
        public string controllerName = "Html";
        public IActionResult Index()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Home";
            return View();
        }
        public IActionResult Tags()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Tags";
            return View();
        }
        public IActionResult Colors()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Colors";
            return View();
        }

        
        public IActionResult BasicExample()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Basic Example";
            return View();
        }
        
        // HTML Comments
        public IActionResult Comments()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Comments";
            return View();
        }

        public IActionResult CSS()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "CSS";
            return View();
        }
       
    public IActionResult ColorPicker()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Color Picker";
        return View();
    }
    
    public IActionResult MathSymbols()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Math Symbols";
        return View();
    }
    
    }
}