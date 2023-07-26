using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_MVC_L63_DB_Apprch_Mstr_2623.Models;

namespace WebApp_MVC_L63_DB_Apprch_Mstr_2623.Areas.JobSeeker.Controllers
{
    public class JobSeekerController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        public ActionResult JobSeekerHome()
        {
            int JSID = Convert.ToInt32(Session["Skid"]);
            var data = (from a in db.tblJobSeekers where a.JobSeeker_id == JSID select a).ToList();
            return View(data);
        }
    }
}