using System.Web;
using System.Web.Mvc;

namespace Phan_Văn_Hòa_CNTT2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
