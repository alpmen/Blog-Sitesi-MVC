using BusinessLayer.Concrate;
using BusinessLayer.ValidationRules;
using DataAccesLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCKamp.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact

        ContactManager cm = new ContactManager(new EFContactDal());
        ContactValidator cv = new ContactValidator();
        public ActionResult Index()
        {
            var contactValues = cm.GetList();
            return View(contactValues);
        }
    }
}