using System.Web;
using System.Web.Mvc;

namespace ShiguetakaElmah
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
