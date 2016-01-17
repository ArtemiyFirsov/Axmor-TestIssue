using System.Web;
using System.Web.Mvc;

namespace Axmor_TestIssue.WebbApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
