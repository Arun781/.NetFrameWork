using System.Web;
using System.Web.Mvc;

namespace ScoffoladingEx22july
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
