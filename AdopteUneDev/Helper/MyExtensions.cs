using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdopteUneDev.DAL;

namespace AdopteUneDev.Helper
{
    public static class MyExtensions
    { 
        //Style pour le menu de catégories
        public static MvcHtmlString MenuCategAndLang(this HtmlHelper Origin,IEnumerable<Categories> categs)
        {
            /*Html a générer
             * <div class="panel-group category-products" id="accordian">
             * <div class="panel panel-default">
                            <div class="panel-heading">
                                <h4 class="panel-title">
                                    <a data-toggle="collapse" data-parent="#accordian" href="#sportswear">
                                       <span class="badge pull-right"><i class="fa fa-plus"></i></span>
                                        Junior Developer
                                    </a>
                               </h4>
                            </div>
                           <div id="sportswear" class="panel-collapse collapse">
                                <div class="panel-body">
                                    <ul>
                                        <li><a href="#">.NET </a></li>
                                        <li><a href="#">PHP </a></li>
                                        <li><a href="#">HTML5 & CSS3 </a></li>
                                        <li><a href="#">ASP.NET</a></li>
                                        <li><a href="#">JQuery </a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        ...
                    </div>*/

            // <div class="panel-group category-products" id="accordian">
                TagBuilder divPrincipal = new TagBuilder("div");
                //inverser le sens des noms des class
                divPrincipal.AddCssClass("category-products");
                divPrincipal.AddCssClass("panel-group");
                //div1.Attributes.Add("id", "accordian");
                divPrincipal.MergeAttribute("id", "accordian", true);


                foreach (Categories CurrentCateg in categs)
                {
                    //<div class="panel panel-default">
                    TagBuilder divCateg = new TagBuilder("div");
                    divCateg.AddCssClass("panel-default");
                    divCateg.AddCssClass("panel");

                    //<div class="panel-heading">
                    TagBuilder divHeading = new TagBuilder("div");
                    divHeading.AddCssClass("panel-heading");

                    //<h4 class="panel-title">
                    TagBuilder H4 = new TagBuilder("h4");
                    H4.AddCssClass("panel-title");

                    //<a data-toggle="collapse" data-parent="#accordian" href="#sportswear">
                    TagBuilder lienToggle = new TagBuilder("a");
                    lienToggle.Attributes.Add("data-toogle", "collapse");
                    lienToggle.Attributes.Add("data-parent", "#accordian");
                    lienToggle.Attributes.Add("href", "#" + CurrentCateg.CategLabel.Replace(" ",""));

                    //<span class="badge pull-right">
                    TagBuilder spanBadge = new TagBuilder("span");
                    spanBadge.AddCssClass("pull-right");
                    spanBadge.AddCssClass("badge");
                    spanBadge.InnerHtml = "<i class=\"fa fa-plus\"></i>";

                    lienToggle.InnerHtml = spanBadge.ToString();
                    lienToggle.InnerHtml += CurrentCateg.CategLabel;
                    H4.InnerHtml = lienToggle.ToString();
                    divHeading.InnerHtml = H4.ToString();
                    divCateg.InnerHtml = divHeading.InnerHtml.ToString();

                    //Ajout des Langs
                    //<div id="sportswear" class="panel-collapse collapse">
                    TagBuilder divLangs = new TagBuilder("div");
                    divLangs.Attributes.Add("id", CurrentCateg.CategLabel.Replace(" ",""));
                    divLangs.AddCssClass("collapse");
                    divLangs.AddCssClass("panel-collapse");

                    //<div class="panel-body">
                    TagBuilder divBody = new TagBuilder("div");
                    divBody.AddCssClass("panel-body");

                    //<ul>
                    TagBuilder tagUl = new TagBuilder("ul");
                    foreach (ITLang item in CurrentCateg.ItLangs)
                    {
                        TagBuilder tagLi = new TagBuilder("li");
                        tagLi.InnerHtml = "<a href=\"#\">" + item.ITLabel + "</a>";
                        //ajout dans le ul
                        tagUl.InnerHtml += tagLi;
                    }

                    divBody.InnerHtml = tagUl.ToString();
                    divLangs.InnerHtml = divBody.ToString();

                    //Ajout categ
                    divCateg.InnerHtml += divLangs.ToString();

                    //Ajout au principal
                    divPrincipal.InnerHtml += divCateg.ToString();
                }
  
            return new MvcHtmlString(divPrincipal.ToString());
        }

        public static MvcHtmlString NombreDeDevParCateg (this HtmlHelper origin , IEnumerable<ITLang> langs)
        {
            /*<div class="brands-name">
                            <ul class="nav nav-pills nav-stacked">
                                <li><a href="#"> <span class="pull-right">(50)</span>Project Manager</a></li>
                                <li><a href="#"> <span class="pull-right">(56)</span>Junior Developer</a></li>
                                <li><a href="#"> <span class="pull-right">(27)</span>Senior Developer</a></li>
                                <li><a href="#"> <span class="pull-right">(32)</span>Internship</a></li>
                                <li><a href="#"> <span class="pull-right">(5)</span>Business Analyst</a></li>
                                <li><a href="#"> <span class="pull-right">(9)</span>Community Manager</a></li>
                            </ul>
                        </div>
                    </div>*/

            //<div class="brands-name">
            TagBuilder divBrand = new TagBuilder("div");
            divBrand.AddCssClass("brand-name");

                //<ul class="nav nav-pills nav-stacked">
                TagBuilder tagUl = new TagBuilder("ul");
                tagUl.AddCssClass("nav-stacked");
                tagUl.AddCssClass("nav-pills");
                tagUl.AddCssClass("nav");

            //création des li
            foreach(ITLang CurrentLang in langs)
            {
                TagBuilder tagLi = new TagBuilder("li");
                TagBuilder aLink = new TagBuilder("a");
                //aLink.Attributes.Add("href", "#" + CurrentLang.ITLabel);
                TagBuilder spanBadge = new TagBuilder("span");
                spanBadge.AddCssClass("pull-right");
                spanBadge.SetInnerText("(" + +")");
                aLink.InnerHtml = CurrentLang.ToString();




            }

        }
    }
}