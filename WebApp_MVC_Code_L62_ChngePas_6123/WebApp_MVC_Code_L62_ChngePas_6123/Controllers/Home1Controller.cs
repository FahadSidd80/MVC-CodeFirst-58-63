using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_MVC_Code_L62_ChngePas_6123.Models;

namespace WebApp_MVC_Code_L62_ChngePas_6123.Controllers
{
    public class Home1Controller : Controller
    {

        DatabaseContext db = new DatabaseContext();
        public ActionResult UserHome()
        {
            var ID = Convert.ToInt32(Session["IDD"]);
            var data = (from a in db.tblRegistrations
                        join b in db.tblCountries on a.country equals b.cid
                        where a.rid == ID
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

       
        public ActionResult ChangePassword()
        {       
            return View();
        }

        [HttpPost]
        public ActionResult ChangePassword(ChangePassword cp)
        {
            int ID = Convert.ToInt32(Session["IDD"]);
            //var data = (from a in db.tblRegistrations where a.rid == ID select a).ToList();
            tblRegistration data = db.tblRegistrations.Find(ID);
            if (data.Password == cp.OldPassword)
            {
                data.Password = cp.NewPassword;
                db.Entry(data).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ViewBag.msgnew = "your password has been changed successfully !!";
            }
            else
            {
                ViewBag.msgold = "old passowrd didn't match, please enter correct password !!";
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("LoginForm", "Login");
        }

    }
}