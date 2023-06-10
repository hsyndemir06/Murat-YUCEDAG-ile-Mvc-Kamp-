using BusinessLayerr.Concrete;
using DataAccessLayerr.EntityFramework;
using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCkampi.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading

        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }



        public ActionResult HeadingReport()
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }



        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valuecategory=(from x in cm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text=x.CategoryName,
                                                    Value=x.CategoryiD.ToString()
                                                }).ToList();

            List<SelectListItem> valuewriter = (from x in wm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.WriterName + " " + x.WriterSurName,
                                                    Value = x.WriteriD.ToString()
                                                }).ToList();
            ViewBag.vlw = valuewriter;
            ViewBag.vlc=valuecategory;
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
           p.HeadingDate=DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditHeading(int id)
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryiD.ToString()
                                                  }).ToList();
            ViewBag.vlc = valuecategory;
            var HeadingValue=hm.GetByiD(id);
            return View(HeadingValue);
        }

        [HttpPost]
        public ActionResult EditHeading(Heading p)
        {
            hm.HeadingUpdate(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteHeading(int id)
        {
            var HeadingValue=hm.GetByiD(id);
            HeadingValue.HeadingStatus = false;
            hm.HeadingDelete(HeadingValue);
            return RedirectToAction("Index");
        }
    }
}