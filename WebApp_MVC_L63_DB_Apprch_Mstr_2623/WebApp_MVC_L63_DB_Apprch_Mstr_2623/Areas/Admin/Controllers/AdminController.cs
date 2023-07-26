using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_MVC_L63_DB_Apprch_Mstr_2623.Models;

namespace WebApp_MVC_L63_DB_Apprch_Mstr_2623.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        public ActionResult AdminHome()
        {
            int Aidd = Convert.ToInt32(Session["Aid"]);
            var data = (from a in db.tblAdmins where a.Admin_id == Aidd select a).ToList();
            return View(data);
        }
    }
}