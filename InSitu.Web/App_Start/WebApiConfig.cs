using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace InSitu.Web
{
    using InSitu.Data.Models.CarInformation;

    using Microsoft.AspNet.OData.Builder;
    using Microsoft.AspNet.OData.Extensions;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            config.Select().Expand().Filter().OrderBy().MaxTop(null).Count();

            var builder = new ODataConventionModelBuilder();
            BuildOData(builder);
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: "odata",
                model: builder.GetEdmModel());
        }

        private static void BuildOData(ODataConventionModelBuilder builder)
        {
            builder.EntitySet<Car>("Cars");
            builder.EntitySet<Brand>("Brands");
            builder.EntitySet<CarModel>("CarModels");
            builder.EntitySet<CarType>("CarTypes");
            builder.EntitySet<FuelType>("FuelTypes");
            builder.EntitySet<PaintType>("PaintTypes");
            builder.EntitySet<Size>("Sizes");
            builder.EntitySet<UseType>("UseTypes");
            builder.EntitySet<Version>("Versions");
        }
    }
}
