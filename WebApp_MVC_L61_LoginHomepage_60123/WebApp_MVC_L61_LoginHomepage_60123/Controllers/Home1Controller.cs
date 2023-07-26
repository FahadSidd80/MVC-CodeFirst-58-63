using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_MVC_L61_LoginHomepage_60123.Models;

namespace WebApp_MVC_L61_LoginHomepage_60123.Controllers
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

       
    }
}