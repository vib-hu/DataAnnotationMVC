using System.Web;
using System.Web.Optimization;

namespace DataAnnotationMVC.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/JqryVal").Include("~/Scripts/jquery.validate*"));
            BundleTable.EnableOptimizations = true;
        }

    }
}