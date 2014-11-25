using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AdopteUneDev.App_Start
{
    public static class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            /*Bundles pour les css
            <link href="css/bootstrap.min.css" rel="stylesheet">
            <link href="css/font-awesome.min.css" rel="stylesheet">
            <link href="css/prettyPhoto.css" rel="stylesheet">
            <link href="css/price-range.css" rel="stylesheet">
            <link href="css/animate.css" rel="stylesheet">
            <link href="css/main.css" rel="stylesheet">
            <link href="css/responsive.css" rel="stylesheet">*/
            bundles.Add(
                new StyleBundle("~/Content/css")
                .Include("~/Content/css/bootstrap.min.css",
                "~/Content/css/font-awesome.min.css",
                "~/Content/css/prettyPhoto.css",
                "~/Content/css/price-range.css",
                "~/Content/css/animate.css",
                "~/Content/css/main.css",
                "~/Content/css/responsive.css")
                );

            //ajout d'un css perso
            //bundle.Add(new StyleBundle(~NomDucustom).Include("le chemin"));

            //Bundles pour le js
            /*   <script src="js/jquery.js"></script>
                <script src="js/bootstrap.min.js"></script>
                <script src="js/jquery.scrollUp.min.js"></script>
                <script src="js/price-range.js"></script>
                <script src="js/jquery.prettyPhoto.js"></script>
                <script src="js/main.js"></script>
             */ 
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Script/jquery.js",                
                "~/Script/jquery.scrollUp.min.js",              
                "~/Script/jquery.prettyPhoto.js",
                "~/Script/main.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
               "~/Script/bootstrap.min.js"));

            //Bundles pour les images
            bundles.Add(new StyleBundle("~/bundles/customs").Include(
               "~/Script/price-range.js")
                );
        }
    }
}