using System.Web;
using System.Web.Mvc;

namespace Conecting_to_database_home
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
