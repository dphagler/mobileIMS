using System.Web;
using System.Web.Optimization;

namespace mobileIMS {
    public class BundleMobileConfig {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/bundles/jquerymobile")
                .Include("~/Scripts/Mobile/jquery.mobile-{version}.js"));

            bundles.Add(new StyleBundle("~/Content/Mobile/css")
                .Include("~/Content/Mobile/Site.Mobile.css"));
            
            bundles.Add(new StyleBundle("~/Content/jquerymobile/css")
                .Include("~/Content/Mobile/jquery.mobile-{version}.css"));
        }
    }
}