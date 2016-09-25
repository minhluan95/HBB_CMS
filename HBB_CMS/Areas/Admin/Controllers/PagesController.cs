using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HBB_CMS.Areas.Admin.Controllers
{
    public class PagesController : Controller
    {
        //
        // GET: /Admin/Pages/
        public ActionResult AllPages()
        {
            return View();
        }
        public ActionResult AddNew()
        {
            return View();
        }
	}
}