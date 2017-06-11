using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;
using WepApiUi.App_Start;

namespace WepApiUi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "Areas/{id}/{controller}/{action}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.Routes.MapHttpRoute(
            //   name: "Api_Get",
            //   routeTemplate: "{controller}/{id}/{action}",
            //   defaults: new { id = RouteParameter.Optional, action = "Get" },
            //   constraints: new { httpMethod = new HttpMethodConstraint("GET") }
            //);

            //config.Routes.MapHttpRoute(
            //   name: "Api_Post",
            //   routeTemplate: "{controller}/{id}/{action}",
            //   defaults: new { id = RouteParameter.Optional, action = "Post" },
            //   constraints: new { httpMethod = new HttpMethodConstraint("POST") }
            //);

            config.Filters.Add(new CustomExceptionFilter());
        }
    }
}
