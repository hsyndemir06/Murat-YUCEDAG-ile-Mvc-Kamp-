using BusinessLayerr.Concrete;
using BusinessLayerr.ValidationRules;
using DataAccessLayerr.EntityFramework;
using EntityLayerr.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCkampi.Controllers
{
    public class MessageController : Controller
    {
        // GET: Inbox

        MessageManager cm = new MessageManager(new EfMessageDal());
        MessageValidator messagevalidator = new MessageValidator();

        [Authorize]
        public ActionResult Inbox(string p)
        {
            var messagelist = cm.GetListInbox(p);
            return View(messagelist);
        }


        public ActionResult Sendbox(string p)
        {
            var messagelist =cm.GetListSendInbox(p);
            return View(messagelist);
        }


        public ActionResult GetInBoxMessageDetails(int id)
        {
            var value = cm.GetByiD(id);
            return View(value);
        }

        public ActionResult GetSendBoxMessageDetails(int id)
        {
            var value = cm.GetByiD(id);
            return View(value);
        }


        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            ValidationResult results = messagevalidator.Validate(p);
            if (results.IsValid)
            {
                p.MessageDate=DateTime.Parse(DateTime.Now.ToShortDateString());
                cm.MessageAdd(p);
                return RedirectToAction("SendBox");
            }
            else
            {
                foreach (var x in results.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }
            return View();

           
        }
    }
}