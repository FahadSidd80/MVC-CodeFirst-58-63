using System.Web;
using System.Web.Mvc;

namespace WebApp_MVC_L58_CodeBoot_31523
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
