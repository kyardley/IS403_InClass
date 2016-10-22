using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApplication.Controllers
{
    public class Forms_HelpersController : Controller
    {
        //Code in the Controller
        // GET: Default
        public ActionResult Index()
        {
            List<SelectListItem> states = new List<SelectListItem>();
            states.Add(new SelectListItem { Text = "Colorado", Value = "0" });
            states.Add(new SelectListItem { Text = "Texas", Value = "1" });
            states.Add(new SelectListItem { Text = "Utah", Value = "2", Selected = true });
            ViewBag.StateNames = states;
            return View();
        }

    }
}