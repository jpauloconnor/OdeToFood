using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name);

            // return RedirectPermanent("http://micrsoft.com");
            //return RedirectToAction("Index", "Home", new { name = name }); 
            //return RedirectToRoute("Default", new { controller = "Home", action = "Contact" });
            //return File(Server.MapPath("~/Content/site.css"), "text/css");
            return Json(new { Message = message, Name = "Scott" }, JsonRequestBehavior.AllowGet);
        }
    }
}