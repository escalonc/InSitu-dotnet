// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BundleConfig.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   The bundle config.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Web
{
    using System.Web;
    using System.Web.Optimization;

    /// <summary>
    /// The bundle config.
    /// </summary>
    public class BundleConfig
    {
        /// <summary>
        /// The register bundles.
        /// </summary>
        /// <param name="bundles">
        /// The bundles.
        /// </param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/vendor").Include(
                "~/Content/Theme/vendors/scripts/script.js"));


            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Theme/vendors/styles/style.css",
                //"~/Content/bootstrap.css",
                "~/Content/site.css"));
        }
    }
}
