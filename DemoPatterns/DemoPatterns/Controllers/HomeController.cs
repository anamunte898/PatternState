using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoPatterns.Models;
using DemoPatterns.PatternClasses;

namespace DemoPatterns.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [AllowAnonymous]
        public ActionResult Index(bool isDispatch = false)
        {
            var model = new TelephoneModel
            {
                IsDispatch = isDispatch
            };
            return View(model);
        }

    }
}
