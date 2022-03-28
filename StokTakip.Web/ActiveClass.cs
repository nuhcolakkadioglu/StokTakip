using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace StokTakip.Web
{
    public static class ActiveClass
    {
        public static string ActivePage(this IHtmlHelper html, string controller, string action)
        {
            string active = "";
            var routeData = html.ViewContext.RouteData;
            string routeController = routeData.Values["controller"].ToString();
            string routeAction = routeData.Values["action"].ToString();
            if(routeController== controller && routeAction==action)
            {
                active = "active";
            }

            return active;
        }
    }
}
