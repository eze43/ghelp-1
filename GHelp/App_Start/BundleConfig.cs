using System.Web;
using System.Web.Optimization;

namespace GHelp
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/eliteTemplete/js").Include(
                "~/assets/node_modules/jquery/jquery-3.2.1.min.js",
                "~/assets/node_modules/popper/popper.min.js",
                "~/assets/node_modules/bootstrap/dist/js/bootstrap.min.js",
                "~/perfect-scrollbar.jquery.min.js",
                "~/dist/js/waves.js",
                "~/dist/js/sidebarmenu.js",
                "~/dist/js/custom.min.js",
                "~/assets/node_modules/raphael/raphael-min.js",
                "~/assets/node_modules/morrisjs/morris.min.js",
                "~/assets/node_modules/jquery-sparkline/jquery.sparkline.min.js",
                "~/dist/js/dashboard1.js",
                "~/assets/node_modules/toast-master/js/jquery.toast.js" ));
            


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            bundles.Add(new StyleBundle("~/eliteTemplete/css").Include(
            "~/assets/node_modules/morrisjs/morris.css",
            "~/assets/node_modules/toast-master/css/jquery.toast.css",
            "~/dist/css/pages/dashboard1.css",
            "~/css-chart/css-chart.css",
            "~/dist/css/style.min.css"));

        }
    }
}
