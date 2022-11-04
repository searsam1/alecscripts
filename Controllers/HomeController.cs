
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
        return View();
    }

    // dotnet-aspnet-codegenerator view ViewName Empty -outDir Views/ViewName
    // dotnet-aspnet-codegenerator razorpage Test Edit -outDir Views/Tests

    public static string ControllerInput(string name="")
    {
        string project = "MvcAlecScripts.csproj";
        if (name == ""){
            name = "NewController";
        }
        string outDir = "Controllers";
        string namespace_ = "MvcAlecScripts.Controllers";
        return $@"dotnet-aspnet-codegenerator -p ""{project}"" controller -name ""{name}Controller"" -outDir ""{outDir}"" -namespace ""{namespace_}""";
    }

    public string CreateController(string name)
    {
        // Code To make a new controller
        // dotnet-aspnet-codegenerator -p "MyProject.csproj" controller -name MyDemoModelController -outDir Controllers -namespace My.Namespace.Controllers
        return ControllerInput(name);
    }

    public IActionResult Privacy()
    {
        ViewData["controller"] = controllerName;
        return View();
    }

    public IActionResult CodeTut()
    {
        ViewData["controller"] = controllerName;
        return View();
    }

    // public IActionResult PythonHomePage()
    // {
    //     return View();
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    
    {
        ViewData["controller"] = controllerName;
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
