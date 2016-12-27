using System.Web.Mvc;

namespace NFine.Web.Areas.FishpondManager
{
    public class FishpondManagerAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "FishpondManager";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "FishpondManager_default",
                "FishpondManager/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
