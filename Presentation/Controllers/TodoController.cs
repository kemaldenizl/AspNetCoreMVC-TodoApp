using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
