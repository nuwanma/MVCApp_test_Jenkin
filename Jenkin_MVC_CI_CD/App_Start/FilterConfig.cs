using System.Web;
using System.Web.Mvc;

namespace Jenkin_MVC_CI_CD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
