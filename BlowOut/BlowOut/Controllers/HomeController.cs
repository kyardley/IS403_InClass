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

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Rental_Form([Bind(Include = "Cust_ID,Cust_FirstName,Cust_LastName,Cust_Address,Cust_City,Cust_State,Cust_Zip,Cust_Email,Cust_Phone")] Customer customer, int id)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();

                //Lookup instrument
                Instrument instrument = db.Instruments.Find(id);
                //Update Instrument
                
               instrument.Cust_ID = customer.Cust_ID;
                db.SaveChanges();


                return RedirectToAction("Confirmation", new { Cust_ID = customer.Cust_ID, Inst_ID= instrument.Inst_ID});
            }

            return View(customer);
        }

        public ActionResult Confirmation(int Cust_ID, int Inst_ID)
        {
            Customer customer = db.Customers.Find(Cust_ID);
            Instrument instrument = db.Instruments.Find(Inst_ID);
            //Sets customer and instrument as ViewBags to send to the View
            ViewBag.Customer = customer;
            ViewBag.Instrument = instrument;
            
            //Calculates the Total Price paid at the end of the 18 months for selected instrument
            string sub = instrument.Inst_Price.Substring(1, 2);
            ViewBag.Total = 18 * Convert.ToInt32(sub);

            //Finds the Image source for selected instrument
            switch (instrument.Inst_Description)
            {
                case "Trumpet":
                    ViewBag.Src = "../Images/trumpet.jpg";
                    break;
                case "Trombone":
                    ViewBag.Src = "../Images/trombone.jpg";
                    break;
                case "French Horn":
                    ViewBag.Src = "../Images/frenchhorn.jpg";
                    break;
                case "Flute":
                    ViewBag.Src = "../Images/flute.jpg";
                    break;
                case "Clarinet":
                    ViewBag.Src = "../Images/clarinet.jpg";
                    break;
                case "Saxaphone":
                    ViewBag.Src = "../Images/sax.jpg";
                    break;
            }
            
            
            
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


    }
}