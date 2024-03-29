using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcAlecScripts.Models;

namespace MvcMovie.Controllers
{
    public class HtmlController : Controller
    {
        // GET: /Python/
        public string controllerName = "Html";
        public IActionResult Index()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Home";
            return View();
        }
        public IActionResult Tags()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Tags";
            return View();
        }
        public IActionResult Colors()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Colors";
            return View();
        }

        
        public IActionResult BasicExample()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Basic Example";
            return View();
        }
        
        // HTML Comments
        public IActionResult Comments()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "Comments";
            return View();
        }

        public IActionResult CSS()
        {
            ViewData["controller"] = controllerName;
            ViewData["title"] = "CSS";
            return View();
        }
       
    public IActionResult ColorPicker(string colorpicker="#0000ff")
    {   
            var viewModel = new HtmlFormsModel
            {
                ColorPickerExampleColor = colorpicker

            };

        ViewData["controller"] = controllerName;
        ViewData["title"] = "Color Picker";
        return View(viewModel);
    }
    
    public IActionResult MathSymbols()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Math Symbols";
        return View();
    }
    
    public IActionResult Forms(string firstName="john", string lastName = "smith")
    {   
            var viewModel = new HtmlFormsModel
            {
                FirstName = firstName,
                LastName = lastName

            };
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Forms";
        return View(viewModel);
    }
    
    public IActionResult InputTypes()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Input Types";
        return View();
    }
    
    public IActionResult CountryCodes()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Country Codes";
        return View();
    }
    
    public IActionResult LanguageCodes()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Language Codes";
        return View();
    }

        public IActionResult FoodForm(float fat=0, float sodium=0, float carbs=0, float sugars=0, float protein=0, float calories=0)
    {   
            var viewModel = new FoodModel
            {
                Fat = fat, Sodium = sodium,
                Carbs = carbs, Sugars = sugars,
                Protein = protein, Calories = calories

            };

        ViewData["controller"] = controllerName;
        ViewData["title"] = "Food Form";
        return View(viewModel);
    }
    
    public IActionResult Markdown()
    {   
        ViewData["creationDate"] = "Mon Jan  2 02:38:28 2023 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Markdown";
        return View();
    }
    
    public IActionResult PostFormatter()
    {   
        ViewData["creationDate"] = "Mon Jan  9 14:55:00 2023 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Post Formatter";
        return View();
    }
    
    public IActionResult Tables()
    {   
        ViewData["creationDate"] = "Sat Jan 21 04:31:15 2023 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Tables";
        return View();
    }
    
    public IActionResult SemanticHtml()
    {   
        ViewData["creationDate"] = "Mon Jan 23 03:30:49 2023 (GMT-7)";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Semantic Html";
        return View();
    }
    
    }
}