
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcAlecScripts.Models;

namespace MvcMovie.Controllers
{
    public class financialController : Controller
    {
        public IActionResult Index()
        {
            
            var viewModel = new FinancialModel(){
                Name = "Alec",
            };
            return View(viewModel);
        }
    }
}