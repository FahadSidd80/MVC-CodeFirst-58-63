using System.Web;
using System.Web.Mvc;

namespace WebApp_58_B_MVC_Bootstrap_Code_31523
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
