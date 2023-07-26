using System.Web;
using System.Web.Mvc;

namespace WebApp_MVC_L63_DB_Apprch_Mstr_2623
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
