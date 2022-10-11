using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class CppController : Controller
    {
        // GET: /Python/

    public IActionResult Index()
    {   
        ViewBag.py = PythonLinks.getLinks();
        return View();
    }
      
    }
}