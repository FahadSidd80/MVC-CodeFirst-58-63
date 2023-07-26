using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_MVC_L57_Code_31523.Models;


namespace WebApp_MVC_L57_Code_31523.Controllers
{
    
    public class EmployeeController : Controller
    {
      DatabaseContext db= new DatabaseContext();
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblEmployee obj)
        {
            db.tblEmployees.Add(obj);
            db.SaveChanges();
            return View();
        }

        public ActionResult Display()
        {
            var data = (from a in db.tblEmployees select a).ToList();
            //ViewBag.data = (from a in db.tblEmployees select a).ToList();
            return View(data);
        }
    }
}