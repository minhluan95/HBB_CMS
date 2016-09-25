using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HBB_CMS.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Admin/Users/
        public ActionResult AllUsers()
        {
            return View();
        }
        public ActionResult AddNew()
        {
            return View();
        }
        public ActionResult YourProfile()
        {
            return View();
        }
	}
}