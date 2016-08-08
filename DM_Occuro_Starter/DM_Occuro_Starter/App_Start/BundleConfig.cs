using System.Web.Optimization;

namespace DM_Occuro_Starter
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(GetScriptBundle());
            bundles.Add(GetStyleBundle());
        }

        private static ScriptBundle GetScriptBundle()
        {
            var scriptBundle = new ScriptBundle("~/bundles/app/scripts");
            
            var scriptPaths = new[]
            {
                "~/Scripts/wwwroot/lib/angular/angular.js"
            };

            scriptBundle.Include(scriptPaths);

            scriptBundle.IncludeDirectory("~/Web/", "*.js", true);

            return scriptBundle;
        }

        private static StyleBundle GetStyleBundle()
        {
            var styleBundle = new StyleBundle("~/bundles/app/css");

            var stylePaths = new[]
            {
                "~/Content/CSS/Core.css"
            };

            styleBundle.Include(stylePaths);

            return styleBundle;
        }
    }
}