using System.Web;
using System.Web.Mvc;

namespace ONE_SMALL_STEP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
