using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_MVC_Code_L62_ChngePas_6123.Models;

namespace WebApp_MVC_Code_L62_ChngePas_6123.Controllers
{
    public class RegistrationController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        public ActionResult RegistrationForm(int id = 0)
        {

            tblRegistration obj = new tblRegistration();
            ViewBag.bt = "Save";
            if (id > 0)
            {
                var data = (from a in db.tblRegistrations where a.rid == id select a).ToList();
                obj.rid = data[0].rid;
                obj.Name = data[0].Name;
                obj.Email = data[0].Email;
                obj.Password = data[0].Password;
                obj.Age = data[0].Age;
                obj.country = data[0].country;
                ViewBag.bt = "Update";

            }
            ViewBag.ctr = db.tblCountries.ToList();
            return View(obj);
        }

        [HttpPost]
        public ActionResult RegistrationForm(tblRegistration obj)
        {
            //if (obj.rid > 0)
            //{
            //    db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            //}
            //else
            //{
            //    if (ModelState.IsValid)
            //    {
            //        db.tblRegistrations.Add(obj);

            //        //return RedirectToAction("RegistrationDisplay");
            //    }
            //    else
            //    {
            //        return View();
            //    }
            //}
            //return View();
            //db.SaveChanges();
            //return RedirectToAction("RegistrationDisplay");

            //sir logic
            if (ModelState.IsValid)
            {
                if (obj.rid > 0)
                {
                    db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    db.tblRegistrations.Add(obj);
                }
                db.SaveChanges();
                return RedirectToAction("RegistrationDisplay");
            }
            else
            {
                return View();
            }



        }


        public ActionResult RegistrationDisplay()
        {
            //var data = (from a in db.tblRegistrations select a).ToList();
            var data = (from a in db.tblRegistrations
                        join b in db.tblCountries on a.country equals b.cid
                        select new Join
                        {
                            rid = a.rid,
                            Name = a.Name,
                            Email = a.Email,
                            Password = a.Password,
                            Age = a.Age,
                            Countryname = b.cname
                        }).ToList();
            return View(data);
        }

        public ActionResult Delete(int id = 0)
        {
            var data = db.tblRegistrations.Find(id);
            db.tblRegistrations.Remove(data);
            db.SaveChanges();
            return RedirectToAction("RegistrationDisplay");
        }
    }
}