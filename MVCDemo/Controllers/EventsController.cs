using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EventsController : Controller
    {
        public List<Booking> events { get; set; }

        public IActionResult Index()
        {
            events = new List<Booking>();
            events.Add(new Booking { Title = "Ask CEO", EventDate = DateTime.Today, Qty = 40 });
            events.Add(new Booking { Title = "Client Meeting", EventDate = DateTime.Today, Qty = 12 });
            events.Add(new Booking { Title = "Training Session", EventDate = DateTime.Today, Qty = 20 });
            events.Add(new Booking { Title = "Project Meeting", EventDate = DateTime.Today, Qty = 4 });

            return View(events);
        }
    }
}