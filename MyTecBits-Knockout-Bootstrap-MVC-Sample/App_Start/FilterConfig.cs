using System.Web;
using System.Web.Mvc;

namespace MyTecBits_Knockout_Bootstrap_MVC_Sample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}