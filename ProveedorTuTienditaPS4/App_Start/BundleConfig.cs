using System.Web;
using System.Web.Optimization;

namespace ProveedorTuTienditaPS4
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información sobre los formularios. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Dashboard/DataTable/css").Include(
                "~/Content/Dasboard/vendors/datatables.net-bs/css/dataTables.bootstrap.min.css",
                "~/Content/Dasboard/vendors/datatables.net-buttons-bs/css/buttons.bootstrap.min.css",
                "~/Content/Dasboard/vendors/datatables.net-fixedheader-bs/css/fixedHeader.bootstrap.min.css",
                "~/Content/Dasboard/vendors/datatables.net-responsive-bs/css/responsive.bootstrap.min.css",
                "~/Content/Dasboard/vendors/datatables.net-scroller-bs/css/scroller.bootstrap.min.css"
                ));

            bundles.Add(new ScriptBundle("~/Dashboard/DataTable/js").Include(
                "~/Content/Dasboard/vendors/datatables.net/js/jquery.dataTables.min.js",
                "~/Content/Dasboard/vendors/datatables.net-bs/js/dataTables.bootstrap.min.js",
                "~/Content/Dasboard/vendors/datatables.net-buttons/js/dataTables.buttons.min.js",
                "~/Content/Dasboard/vendors/datatables.net-buttons-bs/js/buttons.bootstrap.min.js",
                "~/Content/Dasboard/vendors/datatables.net-buttons/js/buttons.flash.min.js",
                "~/Content/Dasboard/vendors/datatables.net-buttons/js/buttons.html5.min.js",
                "~/Content/Dasboard/vendors/datatables.net-buttons/js/buttons.print.min.js",
                "~/Content/Dasboard/vendors/datatables.net-fixedheader/js/dataTables.fixedHeader.min.js",
                "~/Content/Dasboard/vendors/datatables.net-keytable/js/dataTables.keyTable.min.js",
                "~/Content/Dasboard/vendors/datatables.net-responsive/js/dataTables.responsive.min.js",
                "~/Content/Dasboard/vendors/datatables.net-responsive-bs/js/responsive.bootstrap.js",
                "~/Content/Dasboard/vendors/datatables.net-scroller/js/dataTables.scroller.min.js"
                ));
        }
    }
}
