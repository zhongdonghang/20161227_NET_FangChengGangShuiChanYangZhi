using System.Web.Mvc;

namespace NFine.Web.Areas.Meteorological
{
    public class MeteorologicalAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Meteorological";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Meteorological_default",
                "Meteorological/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
