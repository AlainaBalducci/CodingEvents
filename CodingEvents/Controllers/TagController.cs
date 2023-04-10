using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class TagController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
