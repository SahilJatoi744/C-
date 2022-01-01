using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nadroga_Arya_College.Models;

namespace Nadroga_Arya_College.Controllers
{
    public class AdminController : Controller
    {
        NADROGA_ARYA_COLLEGEEntities Db = new NADROGA_ARYA_COLLEGEEntities();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(adminlogin u)
        {
            Db.adminlogins.Add(u);
            Db.SaveChanges();
            return RedirectToAction("Login","Admin");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(adminlogin a)
        {
            var b = Db.adminlogins.Where(f => f.username == a.username && f.password == a.password).FirstOrDefault();
            if(b != null)
            {
                if(b.status == "Admin")
                return RedirectToAction("Index", "Admin");

            }
            else { 
                ViewBag.msg = "Still Request In Pending";
                return View();
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login", "Admin");
        }
        public ActionResult adquest()
        {
            return View(Db.questions.OrderByDescending(a => a.que_id).ToList());
        }
        public ActionResult DeleteQ(int id)
        {
                var u = Db.questions.Where(a => a.que_id == id).FirstOrDefault();
                Db.questions.Remove(u);
                Db.SaveChanges();
                return RedirectToAction("adquest", "Admin");
        }
        public ActionResult Confirm()
        {
            return View(Db.studentregs.OrderByDescending(a => a.id).ToList());
        }
        public ActionResult DeleteS(int id)
        {
            var u = Db.studentregs.Where(a => a.id == id).FirstOrDefault();
            Db.studentregs.Remove(u);
            Db.SaveChanges();
            return RedirectToAction("Confirm", "Admin");
        }
        /*public ActionResult delete_course_model()
        {
            return View();
        }*/
        public ActionResult Generator()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Generator(regcode r)
        {
            Db.regcodes.Add(r);
            Db.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }
        public ActionResult pinList(regcode r)
        {
            if(r.status == "unused") { 
            return View(Db.regcodes.OrderByDescending(a => a.status == "Unused").ToList());
            }
            else
            {
                return View(Db.regcodes.OrderByDescending(a => a.status == "used").ToList());
            }
        }
        public ActionResult DeleteD(int id)
        {
            var u = Db.regcodes.Where(a => a.id == id).FirstOrDefault();
            Db.regcodes.Remove(u);
            Db.SaveChanges();
            return RedirectToAction("pinList", "Admin");
        }
        public ActionResult questionAdd()
        {
            /*ViewBag.Test = new SelectList(Db.mst_test.ToList(), "Id", "Name");*/
            return View();
        }
        [HttpPost]
        public ActionResult questionAdd(question q)
        {
            Db.questions.Add(q);
            Db.SaveChanges();
            return RedirectToAction("Index","Admin");
        }
        public ActionResult subAdd()
        {
           return View();
        }
        [HttpPost]
        public ActionResult subAdd(mst_subject s)
        {
            Db.mst_subject.Add(s);
            Db.SaveChanges();
            return RedirectToAction("Index", "Admin");

        }
        public ActionResult testAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult testAdd(mst_test t)
        {
            Db.mst_test.Add(t);
            Db.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }
    }
}