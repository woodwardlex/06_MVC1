using System.Web.Mvc;

namespace WebSandbox.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Html()
        {
            return View();
        }

        public ActionResult Css()
        {
            return View();
        }

        public ActionResult Colors()
        {
            return View();
        }

        public ActionResult Fonts()
        {
            return View();
        }

        public ActionResult Images()
        {
            return View();
        }

        public ActionResult Tables()
        {
            return View();
        }
    }
}
