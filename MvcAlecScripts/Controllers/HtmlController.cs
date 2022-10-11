using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HtmlController : Controller
    {
        // GET: /Python/

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Tags()
    {
        return View();
    }
       
    }
}