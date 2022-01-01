using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nadroga_Arya_College.Models;

namespace Nadroga_Arya_College.Controllers
{
    public class UserController : Controller
    {
        NADROGA_ARYA_COLLEGEEntities Db = new NADROGA_ARYA_COLLEGEEntities();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Checker()
        {
            return View(Db.studentregs.OrderByDescending(a => a.id).ToList());
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Quiz(studentreg s)
        {
            Session["id"] = s.id;
            Session["surname"] = s.surname;
            Session["school"] = s.school;
            Session["othernames"] = s.othernames;
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(studentreg sr)
        {
            Db.studentregs.Add(sr);
            Db.SaveChanges();
            return RedirectToAction("Index", "User");
        }
        public ActionResult RegConfirm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegConfirm(studentreg sr)
        {
            Session["id"] = sr.id;
            Session["jamb"] = sr.jamb;
            Session["grade1"] = sr.grade1;
            Session["grade2"] = sr.grade2;
            Session["grade3"] = sr.grade3;
            Session["grade4"] = sr.grade4;
            Session["Birthday"] = sr.bday;
            Db.studentregs.Add(sr);
            Db.SaveChanges();
            return RedirectToAction("Index", "User");
        }
        public ActionResult Squestion()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Squestion(suggest s)
        {
            Db.suggests.Add(s);
            Db.SaveChanges();
            return RedirectToAction("Index", "User");
        }





    }
}