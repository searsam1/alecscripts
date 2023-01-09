
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography; // RandomNumberGenerator.GetInt32
using MvcAlecScripts.Models;


namespace MvcAlecScripts.Controllers
{
    public class HomeController : Controller
    {
        public string controllerName = "Home";
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            ViewData["controller"] = controllerName;
            _logger = logger;
        }

        
        public static string RandomQuote(){
            string[] quotes = {
                "\"God created war so that Americans would learn geography.\" - MarkTwain",
                "\"I know not with what weapons World War III will be fought, but World War IV will be fought with sticks and stones.\" - Albert Einstein",
                "“The true soldier fights not because he hates what is in front of him, but because he loves what is behind him.” ― G.K. Chesterton",
                "“Only the dead have seen the end of war.” ― Plato",
                "“Older men declare war. But it is youth that must fight and die.” ― Herbert Hoover",
                "“The supreme art of war is to subdue the enemy without fighting.” ― Sun Tzu, The Art of War",
                "“Your time is limited, so don’t waste it living someone else’s life.” - Steve Jobs",
                "“In the old world, you devoted 30% of your time to building a great service and 70% of your time to shouting about it. In the new world, that inverts.” ― Jeff Bezos"
            };
            int randNum = RandomNumberGenerator.GetInt32(quotes.Length);
            return quotes[randNum];
        }

        public IActionResult Index()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Alec Scripts Home";

            ViewData["RandomQuote"] = RandomQuote();
            

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
}