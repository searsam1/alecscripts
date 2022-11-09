// using System;
// using System.Security.Cryptography;
// using System.Text;
using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    
    public class GlossaryController : Controller
    {
        public string controllerName = "Glossary";
        public IActionResult Index()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Home";
            return View();
        }
    }
}