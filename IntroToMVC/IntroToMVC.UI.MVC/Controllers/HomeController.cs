using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroToMVC.UI.MVC.Controllers
{
    //Just a normal class with some methods
    public class HomeController : Controller
    {
        //method - often referred to as an Action
        public ActionResult Index()
        {
            //By default this action returns a view with the same name as the action (view is found in Views/Home/Index.cshtml)
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TestAction()
        {
            return View();
        }

        //Added this Action and View for IntroToRazor
        public ActionResult IntroToRazor()
        {
            return View();
        }
    }
}