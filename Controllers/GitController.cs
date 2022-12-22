using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcAlecScripts.Controllers
{
    public class GitController : Controller
    {
        public string controllerName = "Git";
        public IActionResult Index()
        {
            ViewData["title"] = "Home";
            ViewData["controller"] = "Git";

            return View();
        }
    public IActionResult Repositories()
    {   
        ViewData["creationDate"] = "Sun Dec 18 09:27:17 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Repositories";
        return View();
    }
    
    public IActionResult Branching()
    {   
        ViewData["creationDate"] = "Sun Dec 18 12:10:56 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Branching";
        return View();
    }
    
    public IActionResult Commits()
    {   
        ViewData["creationDate"] = "Mon Dec 19 02:38:27 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Commits";
        return View();
    }
    
    public IActionResult CommitHistory()
    {   
        ViewData["creationDate"] = "Mon Dec 19 03:18:54 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Commit History";
        return View();
    }
    
    public IActionResult UndoingThings()
    {   
        ViewData["creationDate"] = "Tue Dec 20 08:38:23 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Undoing Things";
        return View();
    }
    
    public IActionResult Remotes()
    {   
        ViewData["creationDate"] = "Wed Dec 21 01:19:01 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Remotes";
        return View();
    }
    
    public IActionResult Tags()
    {   
        ViewData["creationDate"] = "Wed Dec 21 05:12:40 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Tags";
        return View();
    }
    
    public IActionResult Aliases()
    {   
        ViewData["creationDate"] = "Wed Dec 21 23:19:50 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Aliases";
        return View();
    }
    
    public IActionResult BranchManagement()
    {   
        ViewData["creationDate"] = "Thu Dec 22 13:12:20 2022 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Branch Management";
        return View();
    }
    
    }
}