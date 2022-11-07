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
       
    }
}