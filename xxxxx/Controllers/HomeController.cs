using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using xxxx.Db;
using xxxx.Models;
using xxxx.Db.Dboperation;

namespace xxxxx.Controllers
{
    public class HomeController : Controller
    {
        categoryoperation res = new categoryoperation();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Categorymodel model)
        {
            if (ModelState.IsValid) 
            {
                int id = res.savecategory(model);
                if (id>0) 
                {
                    ModelState.Clear();
                    ViewBag.msg = "insert successfully";
                }
            }
            return View();
        }
    }
}