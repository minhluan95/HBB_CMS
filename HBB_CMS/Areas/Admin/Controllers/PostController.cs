using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HBB_CMS.Areas.Admin.Controllers
{
    public class PostController : Controller
    {
        //
        // GET: /Admin/Post/
        public ActionResult AllPost()
        {
            return View();
        }
        public ActionResult AddNew()
        {
            return View();
        }
        public ActionResult Categories()
        {
            return View();
        }
        public ActionResult Tags()
        {
            return View();
        }
        public ActionResult SidebarPartial()
        {
            return PartialView();
        }
    }
}