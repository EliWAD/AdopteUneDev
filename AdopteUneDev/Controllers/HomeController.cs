using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdopteUneDev.DAL;
using AdopteUneDev.Models;

namespace AdopteUneDev.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            Session["ControllerContext"] = this.ControllerContext;
            HomeModel HM = new HomeModel
            {
                lstCategs = Categories.ChargerToutesLesCategories(),
                lstLangs = ITLang.ChargerLesLangs(),
                lstDevs = Developer.ChargerTousLesDevs(),
            };

            return View(HM);

        }
	}
}