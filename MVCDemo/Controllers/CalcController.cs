using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers {
    public class CalcController : Controller {
        // GET: Calc
        public ActionResult Index() {
            return View();
        }


        public ActionResult Sum() {
            return View();
        }
    }
}