using System.Web;
using System.Web.Mvc;

namespace MVC_Lab_2_Grupp_3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
