using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HBB_CMS.Areas.Admin.Controllers
{
    public class CommentsController : Controller
    {
        //
        // GET: /Admin/Comments/
        public ActionResult Comments()
        {
            return View();
        }
	}
}