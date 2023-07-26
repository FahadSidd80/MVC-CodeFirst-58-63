using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_MVC_Code_L62_ChngePas_6123.Models;

namespace WebApp_MVC_Code_L62_ChngePas_6123.Controllers
{
    public class LoginController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        public ActionResult LoginForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginForm(tblRegistration _reg)
        {
            var data = (from a in db.tblRegistrations where a.Email == _reg.Email & a.Password == _reg.Password select a).ToList();
            if (data.Count > 0)
            {
                Session["IDD"] = data[0].rid;
                return RedirectToAction("UserHome", "Home1");
            }
            else
            {
                ViewBag.msg = "Login Failed...";
                return View();
            }

        }
    }
}