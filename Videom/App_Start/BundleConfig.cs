using System.Web;
using System.Web.Optimization;

namespace Videom
{
    public class BundleConfig
    {
        // Aby uzyskać więcej informacji o grupowaniu, odwiedź stronę https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Użyj wersji deweloperskiej biblioteki Modernizr do nauki i opracowywania rozwiązań. Następnie, kiedy wszystko będzie
            // gotowe do produkcji, użyj narzędzia do kompilowania ze strony https://modernizr.com, aby wybrać wyłącznie potrzebne testy.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/videom/videom-black.css"));

            //AdminLTE
            bundles.Add(new StyleBundle("~/Content/AdminLteCss").Include(
                    "~/Content/adminlte/dist/css/skins/_all-skins.min.css",
                    "~/Content/adminlte/dist/css/AdminLTE.min.css",
                    "~/Content/adminlte/bower_components/Ionicons/css/ionicons.min.css",
                    "~/Content/adminlte/bower_components/font-awesome/css/font-awesome.min.css",
                    "~/Content/adminlte/bower_components/bootstrap/dist/css/bootstrap.min.css"));


                 bundles.Add(new ScriptBundle("~/Content/AdminLteJs").Include(
                    "~/Content/adminlte/bower_components/jquery/dist/jquery.min.js",
                    "~/Content/adminlte/bower_components/bootstrap/dist/js/bootstrap.min.js",
                    "~/Content/adminlte/bower_components/jquery-slimscroll/jquery.slimscroll.min.js",
                    "~/Content/adminlte/bower_components/fastclick/lib/fastclick.js",
                    "~/Content/adminlte/dist/js/adminlte.min.js",
                    "~/Content/adminlte/dist/js/demo.js"
                ));
        }
    }
}
