using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;
using WebApiOData.Models;

namespace WebApiOData
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Personeller>("Personeller");
            builder.EntitySet<Isler>("Isler");
            builder.EntitySet<PerIs>("PerIs");
            // OData Route
            config.Routes.MapODataServiceRoute(
                "DefaultOData",
                "odata",
                builder.GetEdmModel()
                );
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
