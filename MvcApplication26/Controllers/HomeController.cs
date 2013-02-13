using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary1;

namespace MvcApplication26.Controllers
{
    public class HomeController : Controller
    {                                         
        private readonly IStoryTeller _teller;
        private IPrintable _printer;

        public HomeController(IStoryTeller teller, IPrintable printer)
        {
            _teller = teller;
            _printer = printer;
        }


        public ActionResult Index()
        {
            string hoi = _teller.GoodMorning();
            Response.Write("<h1>");
            Response.Write(hoi);
            Response.Write("</h1>");

            string s2 = _printer.PrintSomething("asdfasss");
            Response.Write("<h1>");
            Response.Write(s2);
            Response.Write("</h1>");

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }
    }
}
