using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_58_B_MVC_Bootstrap_Code_31523.Models;

namespace WebApp_58_B_MVC_Bootstrap_Code_31523.Controllers
{
    public class RegistrationController : Controller
    {
       DatabaseContext db= new DatabaseContext();
        public ActionResult RegistrationForm()
        {

            return View();
        }
        [HttpPost]
        public ActionResult RegistrationForm(tblRegistration obj)
        {
            if (ModelState.IsValid)
            {
                db.tblRegistrations.Add(obj);
                db.SaveChanges();
                return View();
                //return RedirectToAction("RegistrationDisplay");
            }
            return View();
           
        }


        public ActionResult RegistrationDisplay()
        {
            var data = (from a in db.tblRegistrations select a).ToList();
            return View(data);
        }
    }
}