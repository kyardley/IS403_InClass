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
            string contactMessage = "Please call Support at 801-555-1212. Thanks you!";
            return contactMessage;
        }

        public String Email(string name, string email)
        {
            string response = "Thank you " + name + ". We will send an email to " + email;
            return response;
        }
    }
}