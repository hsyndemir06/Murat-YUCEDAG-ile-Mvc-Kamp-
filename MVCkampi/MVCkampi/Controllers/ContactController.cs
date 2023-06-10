using BusinessLayerr.Concrete;
using BusinessLayerr.ValidationRules;
using DataAccessLayerr.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCkampi.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();

        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }


        public ActionResult GetContactDetails(int id)
        {
            var contactvalue = cm.GetByiD(id);
            return View(contactvalue);
        }

        public PartialViewResult PartialMesaj()
        {
           
            return PartialView();
        }
    }
}