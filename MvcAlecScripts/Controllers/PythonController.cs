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

    public IActionResult GetStreet()
{
    ViewData["title"] = "Model Personal Learning Page";

    var viewModel = new TestModel()
    {
        Street = "1755 29th St, Boulder, CO 80301",
        Name = "Venlafaxine ER",
        Size = "150MG",
        Form = "Capsules",
        Directions = "Take 1 Capsule by mouth daily.",
        RxNumber = "2794372-04952",
        Quantity = 90,
        RefillAuth = "No Refills, needs doctor approval",
    };


    
    return View(viewModel);
}

    }
}