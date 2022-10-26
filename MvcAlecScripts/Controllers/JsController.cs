using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Linq;

namespace MvcMovie.Controllers
{
    public class JsController : Controller
    {
        // GET: /Python/

    public string Get(){
        return @"
        
This is my simple API

        ";
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult jsGetMonth()
    {
        return View();
    }
    public IActionResult Expressions_and_operators()
    {
        return View();
    }
    public IActionResult BinaryArraytoDecimal() 
    {
        return View();
    }
    public IActionResult ToFixed() 
    {
        return View();
    }
    public IActionResult Json()
    {
        return View();
    }
    }
}