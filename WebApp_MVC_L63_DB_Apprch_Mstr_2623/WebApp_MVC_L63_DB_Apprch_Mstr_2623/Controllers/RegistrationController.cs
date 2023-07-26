using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_MVC_L63_DB_Apprch_Mstr_2623.Models;

namespace WebApp_MVC_L63_DB_Apprch_Mstr_2623.Controllers
{
    public class RegistrationController : Controller
    {
    DatabaseContext db = new DatabaseContext();
        public ActionResult RegJobSeeker()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegJobSeeker(tblJobSeeker _jobseekr)// method overloding -- same method name but different parameter.
        {
            _jobseekr.JobSeeker_status = 0;
            db.tblJobSeekers.Add(_jobseekr);
            db.SaveChanges();
            return View();
        }

        public ActionResult RegJobRecruiter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegJobRecruiter(tblJobRecruiter _recruiter)
        {
            _recruiter.JobRecruiter_status = 0;
            db.tblJobRecruiters.Add(_recruiter);
            db.SaveChanges();
            return View();
        }
    }
}