using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REGLOGINMVC.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Registration()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Registration()
        //{
        //    return View();
        //}

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        //public ActionResult Login()
        //{
        //    return View();
        //}
        public ActionResult Home()
        {
            return View();
        }
        [HttpPost]
        //public ActionResult Home()
        //{
        //    return View();
        //}
       
        public ActionResult Edit()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Edit()
        //{
        //    return View();
        //}

    }
}