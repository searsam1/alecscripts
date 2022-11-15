
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

}
