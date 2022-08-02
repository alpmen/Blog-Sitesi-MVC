using BusinessLayer.Concrate;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCKamp.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager hm = new HeadingManager(new EFHeadingDal());
        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        WriterManager wm = new WriterManager(new EFWriterDal());
        public ActionResult Index()
        {
            var headingValues = hm.GetList();
            return View(headingValues);
        }



        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text=x.CategoryName,
                                                      Value=x.CategoryID.ToString()
                                                  }).ToList();


            List<SelectListItem> valueWriter = (from x in wm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.WriterName + " "+ x.WriterSurname,
                                                    Value = x.WriterID.ToString()
                                                }
                                              ).ToList();

            ViewBag.valaueWrt = valueWriter;
            ViewBag.valueCtgr= valueCategory;
            return View();
        }


        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAddBL(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditHeading(int id)
        {
            List<SelectListItem> valueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();

            ViewBag.valueCtgr = valueCategory;


            var headingValue = hm.GetByID(id);
            return View(headingValue);
        }



        [HttpPost]
        public ActionResult EditHeading(Heading p)
        {
            hm.HeadingUpdate(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteHeading(int id)
        {
            //Silme değil durumu güncelleme yapıyor status=false oluyor.
            //HeadingDelete fonksiyonunu inceleyebilirsin
            var headingValue = hm.GetByID(id);
            if (headingValue.HeadingStatus==true)
            {
                headingValue.HeadingStatus = false;
            }
            else if (headingValue.HeadingStatus==false)
            {
                headingValue.HeadingStatus = true;

            }
            hm.HeadingDelete(headingValue);
            return RedirectToAction("Index");
        }



    }
}