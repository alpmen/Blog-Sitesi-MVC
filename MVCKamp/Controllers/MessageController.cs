using BusinessLayer.Concrate;
using DataAccesLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCKamp.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message

        MessageManager mm = new MessageManager(new EFMessageDal());
        public ActionResult Inbox()
        {
            var messageList = mm.GetList();
            return View(messageList);
        }
    }
}