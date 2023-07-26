using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_MVC_L63_DB_Apprch_Mstr_2623.Models;

namespace WebApp_MVC_L63_DB_Apprch_Mstr_2623.Controllers
{
    public class LoginController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        public ActionResult LoginForm()
        {
            ViewBag.UserType = db.tblUserTypes.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult LoginForm(Login _login)
        {
            if (_login.login_UserType == 1)
            {
                var data = (from a in db.tblAdmins where a.Admin_email == _login.login_email & a.Admin_password == _login.login_password select a).ToList();
                if (data.Count > 0)
                {
                    Session["Aid"] = data[0].Admin_id;
                    return RedirectToAction("AdminHome","Admin", new { area = "Admin" });
                }
                else
                {
                    ViewBag.UserType = db.tblUserTypes.ToList();
                    ViewBag.admsg = "Admin login failed... !!";
                    return View();
                }
            }
            else if (_login.login_UserType == 2)
            {
                var data = (from a in db.tblJobSeekers where a.JobSeeker_email == _login.login_email & a.JobSeeker_password == _login.login_password select a).ToList();
                if (data.Count > 0)
                {
                    Session["Skid"] = data[0].JobSeeker_id;
                    return RedirectToAction("JobSeekerHome", "JobSeeker", new { area = "JobSeeker" });
                }
                else
                {
                    ViewBag.UserType = db.tblUserTypes.ToList();
                    ViewBag.skmsg = "Jobseeker login failed... !!";
                    return View();
                }
            }
            else 
            {

                var data = (from a in db.tblJobRecruiters where a.JobRecruiter_email == _login.login_email & a.JobRecruiter_password == _login.login_password select a).ToList();
                if (data.Count > 0)
                {
                    Session["Rcid"] = data[0].JobRecruiter_id;
                    return RedirectToAction("RecruiterHome", "Recruiter", new { area = "JobRecruiter" });
                }
                else
                {
                    ViewBag.UserType = db.tblUserTypes.ToList();
                    ViewBag.jrmsg = "Jobrecruiter login failed... !!";
                    return View();
                }
            }
            //else
            //{
            //    ViewBag.UserType = db.tblUserTypes.ToList();
            //    ViewBag.slmsg = "Please select usertype..!!";
            //    return View();
            //}
            //ViewBag.UserType = db.tblUserTypes.ToList();
            //return View();
        }


    }
}