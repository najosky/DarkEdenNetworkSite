using System.Web;
using System.Web.Mvc;

namespace DarkEdenNetworkSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
