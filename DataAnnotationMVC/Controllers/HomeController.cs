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

            SelectList lst = new SelectList(new SelectListItem[]{ 
            new SelectListItem{Text="Select State",Value="",Selected=true},
            new SelectListItem { Text = "UP", Value = "1" },
            new SelectListItem{Text="Odisa",Value="2"},
            new SelectListItem{Text="Bihar",Value="3"}},"Value","Text");

            ViewBag.States = lst;

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
            SelectList lst = new SelectList(new SelectListItem[]{ 
            new SelectListItem{Text="Select State",Value="",Selected=true},
            new SelectListItem { Text = "UP", Value = "1" },
            new SelectListItem{Text="Odisa",Value="2"},
            new SelectListItem{Text="Bihar",Value="3"}}, "Value", "Text");

            ViewBag.States = lst;
            
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