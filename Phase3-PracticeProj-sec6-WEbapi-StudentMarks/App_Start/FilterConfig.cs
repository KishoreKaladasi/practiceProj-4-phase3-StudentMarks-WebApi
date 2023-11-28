using System.Web;
using System.Web.Mvc;

namespace Phase3_PracticeProj_sec6_WEbapi_StudentMarks
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
