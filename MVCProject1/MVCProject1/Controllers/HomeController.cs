using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using BOL;

namespace MVCProject1.Controllers
{
    public class HomeController : Controller
    {
        private CategoryBs _objCATBs;
        public HomeController()
        {
            _objCATBs = new CategoryBs();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(CATEGORy cat)
        {
            int x = _objCATBs.GetByName(cat);
            if (x==1)
            {
              return  RedirectToAction("Login");
            }
            else
            {
               return  RedirectToAction("Index");
            }

           // return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}