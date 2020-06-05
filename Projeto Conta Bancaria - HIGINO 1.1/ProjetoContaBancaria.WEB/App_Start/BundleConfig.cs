using System.Web;
using System.Web.Optimization;

namespace ProjetoContaBancaria.WEB
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css",
                      "~/Content/bootstrap-grid.css",
                      "~/Content/bootstrap-grid.css.map",
                      "~/Content/bootstrap-grid.min.css",
                      "~/Content/bootstrap-grid.min.css.map",
                      "~/Content/bootstrap-reboot.css",
                      "~/Content/bootstrap-reboot.css.map",
                      "~/Content/bootstrap-reboot.min.css",
                      "~/Content/bootstrap-reboot.min.css.map",
                      "~/Content/bootstrap.css.map",
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap.min.css.map"));
        }
    }
}
