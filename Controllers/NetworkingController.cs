using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Linq;

namespace MvcAlecScripts.Controllers
{
    
    public class NetworkingController : Controller
    {

        public string controllerName = "Networking";
        public IActionResult Index()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Home";
            return View();
        }
        public IActionResult IpDataGram()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Ip Data Gram";
            return View();
        }
    
    }
}