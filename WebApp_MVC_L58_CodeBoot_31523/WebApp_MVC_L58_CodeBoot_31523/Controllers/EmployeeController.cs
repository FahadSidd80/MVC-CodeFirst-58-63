using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_MVC_L58_CodeBoot_31523.Models;

namespace WebApp_MVC_L58_CodeBoot_31523.Controllers
{
    public class EmployeeController : Controller
    {

        DatabaseContext db = new DatabaseContext();
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblEmployee obj)
        {
            if (ModelState.IsValid)
            {
                db.tblEmployees.Add(obj);
                db.SaveChanges();
                return RedirectToAction("Display");
            }
            else
            {
                return View();
            }   
        }

        public ActionResult Display()
        {
            var data = (from a in db.tblEmployees select a).ToList();
            //ViewBag.data = (from a in db.tblEmployees select a).ToList();
            return View(data);
        }
    }
}