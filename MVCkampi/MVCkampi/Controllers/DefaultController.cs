using BusinessLayerr.Concrete;
using DataAccessLayerr.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCkampi.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default

        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        ContentManager cm = new ContentManager(new EfContentDal());



        public ActionResult Headings()
        {
            var headingSolMenu = hm.GetList();
            return View(headingSolMenu);
        }

        public PartialViewResult Index(int id = 0)
        {
            var contentlist = cm.GetListByHeadingiD(id);
            return PartialView(contentlist);
        }
    }
}