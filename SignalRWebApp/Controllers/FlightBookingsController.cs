using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignalRWebApp.SqlServerNotifier;
using System.Data.Entity;
using System.Threading.Tasks;
using SignalRWebApp.Models;
namespace SignalRWebApp.Controllers
{
    public class FlightBookingsController : Controller
    {
        private FlightBookingsContext db = new FlightBookingsContext();

        public async Task<ActionResult> Index()
        {
            var collection = db.FlightBookings;
            ViewBag.NotifierEntity = db.GetNotifierEntity<FlightBookings>(collection).ToJson();
            return View(await collection.ToListAsync());

        }

        public async Task<ActionResult> IndexPartial()
        {
            var collection = db.FlightBookings;
            ViewBag.NotifierEntity = db.GetNotifierEntity<FlightBookings>(collection).ToJson();
            return PartialView(await collection.ToListAsync());
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}