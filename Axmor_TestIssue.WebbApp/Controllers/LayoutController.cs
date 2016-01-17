using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.IVWS.AdminPanel.App_Start;

namespace App.IVWS.AdminPanel.Controllers
{
    [RequireBasicAuthentication]
    public class LayoutController : Controller
    {
        // GET: Layout
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Carriers()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Test()
        {
            var cred = System.Text.ASCIIEncoding.ASCII
                    .GetString(Convert.FromBase64String(
                    Request.Headers["Authorization"].Substring(6)))
                    .Split(':');
            var user = new { Name = cred[0], Pass = cred[1] };
            return Content(String.Format("user:{0}, password:{1}",
                user.Name, user.Pass));
        }
    }
}