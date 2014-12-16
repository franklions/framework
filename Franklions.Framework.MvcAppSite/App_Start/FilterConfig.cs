using System.Web;
using System.Web.Mvc;

namespace Franklions.Framework.MvcAppSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}