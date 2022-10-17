using System;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class DotnetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult randomNumber(){
            return View();
        }
    }
}