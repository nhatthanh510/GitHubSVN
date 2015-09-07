using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAndWcf.Models;

namespace MvcAndWcf.Controllers
{
    public class HelloController : Controller
    {
        HomeModel model = new HomeModel();
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Hello(HomeModel model) {
            model.information.Id = 1;
            model.information.Name = "Thanh Kute";
            model.information.Age = 25;

            model.companyinfo.companyName = "Global CyberSoft";
            model.companyinfo.companyId = 1;
            model.companyinfo.Location = "CVPM Quang Trung";

            DefaultServiceReference.Service1Client myserv = new DefaultServiceReference.Service1Client();
            myserv.GetData(1);
            return View("HelloView", model);
        }
    }
}