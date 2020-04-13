using System.Web;
using System.Web.Optimization;

namespace ONE_SMALL_STEP
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/esm/popper.js"

                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                //"~/Content/bootstrap-lumen.css",
                "~/Content/bootstrap-spacelab.css",
                "~/Content/site.css",
                "~/Content/site-testing.css",
                "~/Content/ui-grid.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
            "~/Scripts/angular.js",
            "~/Scripts/angular-route.js"));

            bundles.Add(new ScriptBundle("~/bundles/uigrid").Include(
            "~/Scripts/ui-grid.min.js"));


        }
    }
}
