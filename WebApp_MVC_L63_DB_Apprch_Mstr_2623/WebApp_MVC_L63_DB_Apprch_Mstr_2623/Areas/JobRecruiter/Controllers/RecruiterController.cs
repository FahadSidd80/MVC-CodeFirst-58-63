using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_MVC_L63_DB_Apprch_Mstr_2623.Models;

namespace WebApp_MVC_L63_DB_Apprch_Mstr_2623.Areas.JobRecruiter.Controllers
{
    public class RecruiterController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        public ActionResult RecruiterHome()
        {
            int Rcidd = Convert.ToInt32(Session["Rcid"]);
            var data = (from a in db.tblJobRecruiters where a.JobRecruiter_id == Rcidd select a).ToList();
            return View(data);
        }
    }
}