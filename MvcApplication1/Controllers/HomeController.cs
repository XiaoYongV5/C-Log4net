using Emrys.FlashLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            FlashLogger.Debug("Debug");
            FlashLogger.Debug("Debug", new Exception("testexception"));
            FlashLogger.Info("Info");
            FlashLogger.Fatal("Fatal");
            FlashLogger.Error("Error");
            FlashLogger.Warn("Warn", new Exception("testexception"));

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
