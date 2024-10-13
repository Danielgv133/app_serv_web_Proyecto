using System.Web;
using System.Web.Mvc;

namespace app_Serv_web_proyecto_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
