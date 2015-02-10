using System.Web;
using System.Web.Optimization;

namespace ASP.NET.MVC5.Client
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/App_JS/compounents/jquery/2.1.1/jquery.js",
                        "~/App_JS/compounents/bootstrap/3.1.1/js/bootstrap.js",
                        "~/App_JS/compounents/angular/1.3.0/angular.js",
                        "~/App_JS/compounents/angular/1.3.0/angular-route.js",
                        "~/App_JS/compounents/angular/1.3.0/angular-sanitize.js",
                        "~/App_JS/compounents/angular/1.3.0/angular-animate.js",
                        "~/App_JS/compounents/bootstrapHoverDropdown/bootstrap-hover-dropdown.min.js",
                        "~/App_JS/compounents/backtotop/back-to-top.js",
                        "~/App_JS/compounents/FlexSlider/2.2.2/jquery.flexslider.js",
                        "~/App_JS/compounents/jflickrfeed/jflickrfeed.min.js",
                        "~/App_JS/ng-app/app.js",
                        "~/App_JS/ng-app/config.js",
                        "~/App_JS/ng-app/services/sessionStore.js",
                        "~/App_JS/ng-app/factories/logger.js",
                        "~/App_JS/ng-app/directives/ng-carousel.js",
                        "~/App_JS/ng-app/directives/ng-flexslider.js" ,
                          "~/App_JS/ng-app/directives/Controls/ng-enumarable.js"
                       ));

            bundles.Add(new ScriptBundle("~/bundles/scriptsLegacy").Include(
                       "~/App_JS/compounents/jquery/1.11.1/jquery.js",
                       "~/App_JS/compounents/bootstrap/3.1.1/js/bootstrap.js",
                       "~/App_JS/compounents/angular/1.2.9/angular.js",
                       "~/App_JS/compounents/angular/1.2.9/angular-route.js",
                       "~/App_JS/compounents/angular/1.2.9/angular-sanitize.js",
                       //"~/App_JS/compounents/angular/1.2.9/angular-animate.js",
                       "~/App_JS/compounents/bootstrapHoverDropdown/bootstrap-hover-dropdown.min.js",
                       "~/App_JS/compounents/backtotop/back-to-top.js",
                       "~/App_JS/compounents/placeholder/2.0.7/jquery.placeholder.js",
                       "~/App_JS/compounents/prettyPhoto/3.1.5/js/jquery.prettyPhoto.js",
                       "~/App_JS/compounents/FlexSlider/2.2.2/jquery.flexslider.js",
                       "~/App_JS/compounents/jflickrfeed/jflickrfeed.min.js",
                       "~/App_JS/ng-app/app.js",
                       "~/App_JS/ng-app/config.js",
                       "~/App_JS/ng-app/factories/logger.js",
                       "~/App_JS/ng-app/directives/ng-carousel.js",
                       "~/App_JS/ng-app/directives/ng-flexslider.js",
                       "~/App_JS/ng-app/directives/Controls/ng-enumarable.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/ieshim").Include(
                    "~/App_JS/compounents/html5shiv/3.7.0/html5shiv.js",
                    "~/App_JS/compounents/respond/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/App_JS/compounents/collegeGreen/font.css",
                     "~/App_JS/compounents/bootstrap/3.1.1/css/bootstrap.css",
                     "~/App_JS/compounents/font-awesome/4.0.3/css/font-awesome.css",
                     "~/App_JS/compounents/FlexSlider/2.2.2/flexslider.css",
                     "~/App_JS/compounents/toastr/2.0.1/css/toastr.css" 
                     ));
        }
    }
}
