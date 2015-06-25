using System.Web;
using System.Web.Optimization;

namespace LdapManager
{
    public class BundleConfig
    {
        // バンドルの詳細については、http://go.microsoft.com/fwlink/?LinkId=301862  を参照してください
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/scripts/bundle").Include(
                "~/Scripts/Bundle/jquery-{version}.js",
                "~/Scripts/Bundle/jquery.validate.js",
                "~/Scripts/Bundle/bootstrap.js",
                "~/Scripts/Bundle/angular.js"
                ));

            bundles.Add(new StyleBundle("~/styles/bundle").Include(
                "~/Content/Styles/Bundle/bootstrap.css"
                ));
        }
    }
}
