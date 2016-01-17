using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Axmor_TestIssue.WebbApp.Models;

namespace Axmor_TestIssue.WebbApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Items()
        {
            var factory = new ItemsFactory();
            return View(factory.GetAllItems());
        }
    }
}