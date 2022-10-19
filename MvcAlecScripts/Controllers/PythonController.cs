using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcAlecScripts.Models;

namespace MvcMovie.Controllers
{
    public class PythonLinks {
        public static string getLinks(){
            return "s";
        }
    }
    public class PythonController : Controller
    {
        // GET: /Python/

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Password()
    {
        return View();
    }

    public IActionResult swapcase()
    {
        return View();
    }
    public IActionResult vars()
    {
        return View();
    }
    
    public IActionResult abs()
    {
        return View();
    }

    public IActionResult funnyNumbers()
    {
        return View();
    }
    public IActionResult stringFormattingTypes()
    {
        return View();
    }

    public IActionResult controllerGetter()
    {
        return View();
    }

    // make an api
    // public IActionResult cg()
    // {
    //     return View("controllerGetter");
    // }

    }
}