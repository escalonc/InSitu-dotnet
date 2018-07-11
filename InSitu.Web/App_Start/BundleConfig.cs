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
                "~/Content/Theme/vendors/scripts/script.js",
                "~/Content/Theme/src/plugins/datatables/media/js/jquery.dataTables.min.js",
                "~/Content/Theme/src/plugins/datatables/media/js/dataTables.bootstrap4.js",
                "~/Content/Theme/src/plugins/datatables/media/js/dataTables.responsive.js",
                "~/Content/Theme/src/plugins/datatables/media/js/responsive.bootstrap4.js",
                "~/Content/Theme/src/plugins/datatables/media/js/button/dataTables.buttons.js",
                "~/Content/Theme/src/plugins/datatables/media/js/button/buttons.bootstrap4.js",
                "~/Content/Theme/src/plugins/datatables/media/js/button/buttons.print.js",
                "~/Content/Theme/src/plugins/datatables/media/js/button/buttons.html5.js",
                "~/Content/Theme/src/plugins/datatables/media/js/button/buttons.flash.js",
                "~/Content/Theme/src/plugins/datatables/media/js/button/pdfmake.min.js",
                "~/Content/Theme/src/plugins/datatables/media/js/button/vfs_fonts.js")
                .IncludeDirectory("~/Scripts/AppScripts", "*.js", true));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Theme/vendors/styles/style.css",
                "~/Content/Theme/src/plugins/datatables/media/css/jquery.dataTables.css",
                "~/Content/Theme/src/plugins/datatables/media/css/dataTables.bootstrap4.css",
                "~/Content/Theme/src/plugins/datatables/media/css/responsive.dataTables.css",
                "~/Content/site.css"));
        }
    }
}
