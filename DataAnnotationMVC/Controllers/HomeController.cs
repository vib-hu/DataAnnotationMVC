using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAnnotationMVC.Models;

namespace DataAnnotationMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        [ActionName("Index")]
        public ActionResult GetEmployee(Employee e)
        {
            if (ModelState.IsValid)
            {

            }
            else
            { 
            
            
            }
            return View("Index", e);
        }

        public ActionResult CheckUser(String UserName)
        {

            if (UserName != null)
            {
                if (UserName.ToLower() == "vibhu")
                {
                    return Json(false, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}