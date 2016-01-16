using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInviteMVC4.Models;

namespace PartyInviteMVC4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Title = "Index";
            ViewBag.Greeting = hour < 12 ?  "Good Morning" : "Good Afternoon";
            return View();
        }
        [HttpGet]
        public ViewResult RSVPForm()
        {
            ViewBag.Title = "RSVP Form";
            return View();
        }
        [HttpPost]
        public ViewResult RSVPForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Title = "Thanks";
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }


    }
}
