using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyTecBits_Knockout_Bootstrap_MVC_Sample.Models;

namespace MyTecBits_Knockout_Bootstrap_MVC_Sample.Controllers
{
    public class MTB_ArticlesController : Controller
    {
        private MyTecBitsDBContext db = new MyTecBitsDBContext();

        //
        // GET: /MTB_Articles/

        public ActionResult Index()
        {
            return View(db.MyTecBitsDB.ToList());
        }

        //
        // GET: /MTB_Articles/Details/5

        public ActionResult Details(int id = 0)
        {
            MTB_Article mtb_article = db.MyTecBitsDB.Find(id);
            if (mtb_article == null)
            {
                return HttpNotFound();
            }
            return View(mtb_article);
        }

        //
        // GET: /MTB_Articles/Create

        public ActionResult Create()
        {
            return View();
        }

        public JsonResult FillIndex()
        {
            return Json(db.MyTecBitsDB.ToList(), JsonRequestBehavior.AllowGet);
        }

        //
        // POST: /MTB_Articles/Create

        [HttpPost]
        public String Create(MTB_Article mtb_article)
        {
            db.MyTecBitsDB.Add(mtb_article);
            db.SaveChanges();
            return "success";
        }

        //
        // GET: /MTB_Articles/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MTB_Article mtb_article = db.MyTecBitsDB.Find(id);
            if (mtb_article == null)
            {
                return HttpNotFound();
            }
            return View(mtb_article);
        }

        //
        // POST: /MTB_Articles/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MTB_Article mtb_article)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mtb_article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mtb_article);
        }

        //
        // GET: /MTB_Articles/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MTB_Article mtb_article = db.MyTecBitsDB.Find(id);
            if (mtb_article == null)
            {
                return HttpNotFound();
            }
            return View(mtb_article);
        }

        //
        // POST: /MTB_Articles/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MTB_Article mtb_article = db.MyTecBitsDB.Find(id);
            db.MyTecBitsDB.Remove(mtb_article);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}