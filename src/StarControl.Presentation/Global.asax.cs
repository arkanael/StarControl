using AutoMapper;
using StarControl.Presentation.Mappings;
using System.Web.Mvc;
using System.Web.Routing;

namespace StarControl.Presentation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Mapper.Initialize(cfg => { cfg.AddProfile<AutoMapperConfig>(); });

        }
    }
}
