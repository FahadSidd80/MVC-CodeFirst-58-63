using System.Web.Mvc;

namespace WebApp_MVC_L63_DB_Apprch_Mstr_2623.Areas.JobRecruiter
{
    public class JobRecruiterAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "JobRecruiter";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "JobRecruiter_default",
                "JobRecruiter/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}