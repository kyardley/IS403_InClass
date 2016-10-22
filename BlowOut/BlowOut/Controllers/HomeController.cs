using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rentals()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SelectedInstrument(string instrumentID)
        {
            ViewBag.Instrument = instrumentID;

            switch (instrumentID)
            {
                case "Trumpet":
                    ViewBag.New = "$55/month";
                    ViewBag.Used = "$25/month";
                    ViewBag.Src = "../Images/trumpet.jpg";
                    break;
                case "Trombone":
                    ViewBag.New = "$60/month";
                    ViewBag.Used = "$35/month";
                    ViewBag.Src = "../Images/trombone.jpg";
                    break;
                case "French Horn":
                    ViewBag.New = "$70/month";
                    ViewBag.Used = "$50/month";
                    ViewBag.Src = "../Images/frenchhorn.jpg";
                    break;
                case "Flute":
                    ViewBag.New = "$40";
                    ViewBag.Used = "$25";
                    ViewBag.Src = "../Images/flute.jpg";
                    break;
                case "Clarinet":
                    ViewBag.New = "$35";
                    ViewBag.Used = "$27";
                    ViewBag.Src = "../Images/clarinet.jpg";
                    break;
                case "Saxaphone":
                    ViewBag.New = "$42";
                    ViewBag.Used = "$30";
                    ViewBag.Src = "../Images/sax.jpg";
                    break;
            }
            return View();
        }
    }
}