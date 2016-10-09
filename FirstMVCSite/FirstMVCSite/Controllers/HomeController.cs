using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCSite.Models;

namespace FirstMVCSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {

            int hour = DateTime.Now.Hour;

            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            ViewBag.Buckwheat = "Miles Anderson";

            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse response)
        {
            if (ModelState.IsValid)
            {
                return View("ThankYou", response);
            }
            else
            {

            }
            return View();
        }
    }

}
