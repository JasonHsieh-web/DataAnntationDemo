using DataAnnotation_Demo.filter;
using DataAnnotation_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAnnotation_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [TestFilter]
        public ActionResult Index()
        {
            //User user = new User
            //{
            //    Name = "abc"
            //};
            //ViewBag.user = user;
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);

            }
            ViewBag.Name = user.Name;
            return View();
        }

        


        public JsonResult CheckName(string nickName)
        {
            if (nickName != "ABC")
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
                return Json(true, JsonRequestBehavior.AllowGet);

        }

    }
}