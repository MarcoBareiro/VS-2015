using System.Web.Mvc;

namespace MVC_Bootstrap.Areas.bootstrap
{
    public class bootstrapAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "bootstrap";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "bootstrap_default",
                "bootstrap/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
