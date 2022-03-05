using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace HelloMvc.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return Content("<h1>Hello World</h1>", "text/html");
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }

    }
}