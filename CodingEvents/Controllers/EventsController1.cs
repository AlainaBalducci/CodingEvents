using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    
    public class EventsController1 : Controller
    {
        private static List<string> Events = new List<string>();
        [Route("/Events")]
        public IActionResult Index()
        {
           
            ViewBag.events = Events;

            return View();
        }
        [HttpGet]
        [Route("/Events/Add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("Events/Add")]
        public IActionResult NewEvent(string name)
        {
            Events.Add(name);
            return Redirect("/Events");
        }

        
    }
}
