using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEvents.Data;
using CodingEvents.Models;
using CodingEvents.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodingEvents.Controllers
{
    public class EventCategoryController : Controller
    {
        private EventDbContext context;

        public EventCategoryController(EventDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<EventCategory> categories = context.Categories.ToList();
            return View(categories);

        }

        [HttpGet]
        [Route("EventCategory/Create")]
        public IActionResult Create() 
        {
            AddEventCategoryViewModel addEventCategoryViewModel = new AddEventCategoryViewModel();
            return View();
        }

        [HttpPost]
        [Route("EventCategory/Create")]
        public IActionResult ProcessCreateEventCategoryForm(AddEventCategoryViewModel addEventCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                EventCategory newCategory = new EventCategory
                {
                    Name = addEventCategoryViewModel.Name,
                  
                };

                context.Categories.Add(newCategory);
                context.SaveChanges();
                return Redirect("EventCategory");
            }

            return View("EventCategory/Create");
        }
    }
}

