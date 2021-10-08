using System.Web.Optimization;

namespace WebApplication.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundle)
        {
            bundle.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Content/css/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/responsive/css").Include("~/Content/css/responsive.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/colors1/css").Include("~/Content/css/colors1.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/custom/css").Include("~/Content/css/custom.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/animate/css").Include("~/Content/css/animate.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/revolution/settings/css").Include("~/Content/revolution/css/settings.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/revolution/layers/css").Include("~/Content/revolution/css/layers.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/revolution/navigation/css").Include("~/Content/revolution/css/navigation.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/style/css").Include("~/Content/css/style.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/login/css").Include("~/Content/css/login.css", new CssRewriteUrlTransform()));

            bundle.Add(new ScriptBundle("~/bundle/jquery/js").Include("~/Content/js/jquery.min.js"));
            bundle.Add(new ScriptBundle("~/bundle/bootstrap/js").Include("~/Content/js/bootstrap.js"));
            bundle.Add(new ScriptBundle("~/bundle/menumaker/js").Include("~/Content/js/menumaker.js"));
            bundle.Add(new ScriptBundle("~/bundle/wow/js").Include("~/Content/js/wow.js")); 
            bundle.Add(new ScriptBundle("~/bundle/custom/js").Include("~/Content/js/custom.js"));
            bundle.Add(new ScriptBundle("~/bundle/revolution/themepunch/tools/js").Include("~/Content/revolution/js/jquery.themepunch.tools.min.js"));
            bundle.Add(new ScriptBundle("~/bundle/revolution/themepunch/revolution/js").Include("~/Content/revolution/js/jquery.themepunch.revolution.min.js"));
            bundle.Add(new ScriptBundle("~/bundle/revolution/actions/js").Include("~/Content/revolution/js/extensions/revolution.extension.actions.min.js"));
            bundle.Add(new ScriptBundle("~/bundle/revolution/carousel/js").Include("~/Content/revolution/js/extensions/revolution.extension.carousel.min.js"));
            bundle.Add(new ScriptBundle("~/bundle/revolution/kenburn/js").Include("~/Content/revolution/js/extensions/revolution.extension.kenburn.min.js"));
            bundle.Add(new ScriptBundle("~/bundle/revolution/layeranimation/js").Include("~/Content/revolution/js/extensions/revolution.extension.layeranimation.min.js"));
            bundle.Add(new ScriptBundle("~/bundle/revolution/migration/js").Include("~/Content/revolution/js/extensions/revolution.extension.migration.min.js"));
            bundle.Add(new ScriptBundle("~/bundle/brevolution/navigation/js").Include("~/Content/revolution/js/extensions/revolution.extension.navigation.min.js")); 
            bundle.Add(new ScriptBundle("~/bundle/revolution/parallax/js").Include("~/Content/revolution/js/extensions/revolution.extension.parallax.min.js"));
            bundle.Add(new ScriptBundle("~/bundle/revolution/slideanims/js").Include("~/Content/revolution/js/extensions/revolution.extension.slideanims.min.js"));
            bundle.Add(new ScriptBundle("~/bundle/revolution/video/js").Include("~/Content/revolution/js/extensions/revolution.extension.video.min.js"));

            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------

            bundle.Add(new StyleBundle("~/bundles/vendor/bootstrap/css").Include("~/Content/vendor/bootstrap/css/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/fonts/font-awesome/css").Include("~/Content/fonts/font-awesome-4.7.0/css/font-awesome.min.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/fonts/iconic/css").Include("~/Content/fonts/iconic/css/material-design-iconic-font.min.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/vendor/animate/css").Include("~/Content/vendor/animate/animate.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/vendor/css-hamburgers/css").Include("~/Content/vendor/css-hamburgers/hamburgers.min.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/vendor/animsition/css").Include("~/Content/vendor/animsition/css/animsition.min.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/vendor/select2/css").Include("~/Content/vendor/select2/select2.min.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/vendor/daterangepicker/css").Include("~/Content/vendor/daterangepicker/daterangepicker.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/util/css").Include("~/Content/css/util.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/main/css").Include("~/Content/css/main.css", new CssRewriteUrlTransform()));

            bundle.Add(new ScriptBundle("~/bundle/vendor/jquery/js").Include("~/Content/vendor/jquery/jquery-3.2.1.min.js"));
            bundle.Add(new ScriptBundle("~/bundle/vendor/animsition/js").Include("~/Content/vendor/animsition/js/animsition.min.js"));
            bundle.Add(new ScriptBundle("~/bundle/vendor/bootstrap/popper/js").Include("~/Content/vendor/bootstrap/js/popper.js"));
            bundle.Add(new ScriptBundle("~/bundle/vendor/bootstrap/js").Include("~/Content/vendor/bootstrap/js/bootstrap.min.js"));
            bundle.Add(new ScriptBundle("~/bundle/vendor/select2/js").Include("~/Content/vendor/select2/select2.min.js"));
            bundle.Add(new ScriptBundle("~/bundle/vendor/daterangepicker/moment/js").Include("~/Content/vendor/daterangepicker/moment.min.js"));
            bundle.Add(new ScriptBundle("~/bundle/vendor/daterangepicker/js").Include("~/Content/vendor/daterangepicker/daterangepicker.js"));
            bundle.Add(new ScriptBundle("~/bundle/vendor/countdowntime/js").Include("~/Content/vendor/countdowntime/countdowntime.js"));
            bundle.Add(new ScriptBundle("~/bundle/main/js").Include("~/Content/js/main.js"));

            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------

            bundle.Add(new StyleBundle("~/bundles/roboto/css").Include("~/Content/css/roboto-font.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/font-awesome-5/css").Include("~/Content/fonts/font-awesome-5/css/fontawesome-all.min.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/style/register/css").Include("~/Content/css/styleRegister.css", new CssRewriteUrlTransform())); 
            

            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------

            bundle.Add(new StyleBundle("~/bundles/materialdesignicons/css").Include("~/Content/assets/vendors/mdi/css/materialdesignicons.min.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/base/css").Include("~/Content/assets/vendors/css/vendor.bundle.base.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/adminstyle/css").Include("~/Content/assets/css/style.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/style/select2/css").Include("~/Content/assets/vendors/select2/select2.min.css", new CssRewriteUrlTransform()));
            bundle.Add(new StyleBundle("~/bundles/style/bootstrap/select2/css").Include("~/Content/assets/vendors/select2-bootstrap-theme/select2-bootstrap.min.css", new CssRewriteUrlTransform()));

            bundle.Add(new ScriptBundle("~/bundle/vendor/base/jquery/js").Include("~/Content/assets/vendors/js/vendor.bundle.base.js"));
            bundle.Add(new ScriptBundle("~/bundle/off-canvas/js").Include("~/Content/assets/js/off-canvas.js"));
            bundle.Add(new ScriptBundle("~/bundle/hoverable-collapse/js").Include("~/Content/assets/js/hoverable-collapse.js"));
            bundle.Add(new ScriptBundle("~/bundle/misc/js").Include("~/Content/assets/js/misc.js"));
            bundle.Add(new ScriptBundle("~/bundle/settings/js").Include("~/Content/assets/js/settings.js"));
            bundle.Add(new ScriptBundle("~/bundle/todolist/js").Include("~/Content/assets/js/todolist.js"));
            bundle.Add(new ScriptBundle("~/bundle/file-upload/js").Include("~/Content/assets/js/file-upload.js"));
            bundle.Add(new ScriptBundle("~/bundle/typehead/js").Include("~/Content/assets/js/typeahead.js"));
            bundle.Add(new ScriptBundle("~/bundle/select2/js").Include("~/Content/assets/js/select2.js"));
        }
    }
}