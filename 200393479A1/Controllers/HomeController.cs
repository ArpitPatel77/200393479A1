using _200393479A1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _200393479A1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            ViewModel vm = new ViewModel()
            {
                Title ="It is about our New Games",
                Message ="We are world best selling game companies.",
                NewItem = "This is your new gaming variable!!"
            };

            return View(vm);
        }

        public ActionResult Support()
        {
            ViewBag.Message = "It's a support page, if you need any help the view this page";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}