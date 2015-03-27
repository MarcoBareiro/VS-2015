using System.Web;
using System.Web.Optimization;

namespace MVC_Bootstrap
{
    public class BundleConfig
    {
        // Para obtener más información acerca de Bundling, consulte http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            // bootstrap
            bundles.Add(new ScriptBundle("~/bundles/BootstrapJquery").Include(
                        "~/bootstrap/devoops-master/jquery/jquery.min.js",
                        "~/bootstrap/devoops-master/plugins/jquery-ui/jquery-ui.min.js",
                        "~/bootstrap/devoops-master/plugins/bootstrap/bootstrap.min.js",
                        "~/bootstrap/devoops-master/plugins/justified-gallery/jquery.justifiedGallery.min.js",
                        "~/bootstrap/devoops-master/plugins/tinymce/tinymce.min.js",
                        "~/bootstrap/devoops-master/plugins/tinymce/jquery.tinymce.min.js",
                        "~/bootstrap/devoops-master/js/devoops.js"//,                        
                        /*"~/bootstrap/devoops-master/plugins/bootstrap/bootstrap.js",
                        
                        "~/bootstrap/devoops-master/plugins/jquery-ui/jquery-ui.js",*/
                        ));

            bundles.Add(new StyleBundle("~/bundles/BootstrapCss").Include(    
                        "~/bootstrap/devoops-master/plugins/bootstrap/bootstrap.css",
                        "~/bootstrap/devoops-master/plugins/fancybox/jquery.fancybox.css",
                        "~/bootstrap/devoops-master/plugins/fullcalendar/fullcalendar.css",
                        "~/bootstrap/devoops-master/plugins/xcharts/xcharts.min.css",
                        "~/bootstrap/devoops-master/plugins/select2/select2.css",  
                        "~/bootstrap/devoops-master/plugins/justified-gallery/justifiedGallery.css",
                        "~/bootstrap/devoops-master/css/style_v1.css",
                        "~/bootstrap/devoops-master/plugins/chartist/chartist.min.css"//,
                        //"~/bootstrap/devoops-master/plugins/bootstrap/bootstrap.min.css"
                        ));



            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información sobre los formularios. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de creación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}