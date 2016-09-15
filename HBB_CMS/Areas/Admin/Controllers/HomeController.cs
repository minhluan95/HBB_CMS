using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HBB_CMS.Models;
namespace HBB_CMS.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        hbb_cmsEntities db = new hbb_cmsEntities();
        // GET: /Admin/Home/
        public ActionResult Home()
        {
            if (Session["Account"] == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                user us = Session["Account"] as user;
                var lstUsers = db.users.Where(x => x.UserName == us.UserName && x.PassWord == us.PassWord);
                return View(lstUsers);
            }
        }
        public ActionResult Login(FormCollection f)
        {
            string sUsername = Request.Form["username"];
            string sPassword = Request.Form["password"];
            user us = db.users.SingleOrDefault(x => x.UserName == sUsername && x.PassWord == sPassword);
            if (us != null) 
            {
                Session["Account"] = us;
                return RedirectToAction("Home");
            }
            ViewBag.ThongBao = "Username or Password is incorrect";
            return PartialView();
        }
        public ActionResult Logout()
        {
            Session["Account"] = null;
            return RedirectToAction("Login");
        }
	}
}