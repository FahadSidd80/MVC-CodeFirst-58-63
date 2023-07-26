using System.Web;
using System.Web.Mvc;

namespace WebApp_MVC_Code_L62_ChngePas_6123
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
