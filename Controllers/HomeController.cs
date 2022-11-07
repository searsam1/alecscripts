
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcAlecScripts.Models;


namespace MvcAlecScripts.Controllers;

public class HomeController : Controller
{
    public string controllerName = "Home";
    
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        ViewData["controller"] = controllerName;
        _logger = logger;
    }

    
    public IActionResult Index()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Home";
        return View();
    }

    public IActionResult Privacy()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Privacy";
        return View();
    }

    public IActionResult CodeTut()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Code Tut";
        return View();
    }

    // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    // public IActionResult Error()
    
    // {
    //     ViewData["controller"] = controllerName;
    //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    // }
}
