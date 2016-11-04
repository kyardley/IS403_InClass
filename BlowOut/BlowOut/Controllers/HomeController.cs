using BlowOut.DAL;
using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


/*
 * Assignment: Blow Out
 * Date: 10/25/2016
 * Description: Online Rental Website
 * Extra: SuperHero Theme, Nav Pills, Image Hover, Back Button.
 * User cannot accidentally go to SelectedInstrument without clicking on a instrument from Rentals
 * 
 */

namespace BlowOut.Controllers
{
    
    public class HomeController : Controller
    {
        private BlowOutContext db = new BlowOutContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rentals()
        {
            return View(db.Instruments.ToList());
        }

        //get
        public ActionResult Rental_Form(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Rental_Form([Bind(Include = "Cust_ID,Cust_FirstName,Cust_LastName,Cust_Address,Cust_City,Cust_State,Cust_Zip,Cust_Phone")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
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
                        ViewBag.New = "$40/month";
                        ViewBag.Used = "$25/month";
                        ViewBag.Src = "../Images/flute.jpg";
                        break;
                    case "Clarinet":
                        ViewBag.New = "$35/month";
                        ViewBag.Used = "$27/month";
                        ViewBag.Src = "../Images/clarinet.jpg";
                        break;
                    case "Saxaphone":
                        ViewBag.New = "$42/month";
                        ViewBag.Used = "$30/month";
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