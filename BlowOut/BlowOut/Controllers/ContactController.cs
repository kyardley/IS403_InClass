using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public String Index()
        {
            string contactMessage = "<p>Please call Support at <b><u>801-555-1212</u></b>. Thank you!</p>";
            return contactMessage;
        }

        public String Email(string name, string email)
        {
            string response = "<p>Thank you " + name + ". We will send an email to " + email + "</p>";
            return response;
        }
    }
}