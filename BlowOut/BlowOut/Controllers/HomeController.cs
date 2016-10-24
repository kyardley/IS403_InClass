using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*
 * Assignment: Blow Out
 * Date: 10/25/2016
 * Description: Online Rental Website
 * Extra: SuperHero Theme, Nav Pills, Image Hover,
 * User cannot accidentally go to SelectedInstrument without clicking on a instrument from Rentals
 * 
 */

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

            if (instrumentID != null)
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
                        ViewBag.New = "$405/month";
                        ViewBag.Used = "$255/month";
                        ViewBag.Src = "../Images/flute.jpg";
                        break;
                    case "Clarinet":
                        ViewBag.New = "$355/month";
                        ViewBag.Used = "$275/month";
                        ViewBag.Src = "../Images/clarinet.jpg";
                        break;
                    case "Saxaphone":
                        ViewBag.New = "$425/month";
                        ViewBag.Used = "$305/month";
                        ViewBag.Src = "../Images/sax.jpg";
                        break;
                }
                return View();
            }
            else
            {
                return RedirectToAction("Rentals");
            }
            
        }
    }
}