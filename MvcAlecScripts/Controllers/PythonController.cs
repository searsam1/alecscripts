using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class PythonController : Controller
    {
        // GET: /Python/

    public IActionResult Index()
    {
        return View();
    }

    // GET: /Python/Functions
    public IActionResult Functions()
    {
        return View();
    }
    public IActionResult split()
    {
        return View();
    }
    public IActionResult passwords()
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
    
    }
}