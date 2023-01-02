
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
        ViewData["title"] = "";
        return View();
    }

    public IActionResult Privacy()
    {
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Privacy";
        return View();
    }

    public IActionResult Directory()
    {   
        ViewData["creationDate"] = "Sat Dec 10 01:53:46 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Directory";
        return View();    
    }

        public IActionResult AboutThisWebsite()
    {   
        ViewData["creationDate"] = "Tue Dec 20 11:11:01 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "About This Website";
        return View();
    }

    
}