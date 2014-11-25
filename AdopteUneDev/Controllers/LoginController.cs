using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdopteUneDev.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Inscription()
        {
            //proposer de s'inscrire

            //av d'enregistrer vérification de la bd si déjà inscrit

            return View();
        }

        [HttpPost]
        public ActionResult Login()
        {
            //si MySession==false
            //demander de se loger

            //else
            //sortir de MySession

            return View();
        }
	}
}