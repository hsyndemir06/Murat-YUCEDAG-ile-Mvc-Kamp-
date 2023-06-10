using BusinessLayerr.Concrete;
using DataAccessLayerr.EntityFramework;
using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCkampi.Controllers.YazarPanel
{
    public class WriterPanelDüzenlemeController : Controller
    {
        // GET: WriterPanelDüzenleme

        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult AddHeading(Heading p)
        //{
        //    p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
        //    hm.HeadingAdd(p);
        //    return RedirectToAction("Index");
        //}

        [HttpGet]
        public ActionResult EditPanelHeading(int id)
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryiD.ToString()
                                                  }).ToList();
            ViewBag.vlc=valuecategory;
            var HeadingValue = hm.GetByiD(id);
            return View(HeadingValue);
        }

        [HttpPost]
        public ActionResult EditPanelHeading(Heading p)
        {
            hm.HeadingUpdate(p);
            return RedirectToAction("EditPanelHeading");
        }

        
    }
}