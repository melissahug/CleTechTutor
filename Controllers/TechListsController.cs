using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CleTechTutor.Models;

namespace CleTechTutor.Controllers
{
    public class TechListsController : Controller
    {
        private CleTechTutorContext db = new CleTechTutorContext();

        // GET: TechLists
        public ActionResult Index()
        {
            return View(db.TechLists.ToList());
        }

        // GET: TechLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TechList techList = db.TechLists.Find(id);
            if (techList == null)
            {
                return HttpNotFound();
            }
            return View(techList);
        }

        // GET: TechLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TechLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TechListID,Description")] TechList techList)
        {
            if (ModelState.IsValid)
            {
                db.TechLists.Add(techList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(techList);
        }

        // GET: TechLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TechList techList = db.TechLists.Find(id);
            if (techList == null)
            {
                return HttpNotFound();
            }
            return View(techList);
        }

        // POST: TechLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TechListID,Description")] TechList techList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(techList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(techList);
        }

        // GET: TechLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TechList techList = db.TechLists.Find(id);
            if (techList == null)
            {
                return HttpNotFound();
            }
            return View(techList);
        }

        // POST: TechLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TechList techList = db.TechLists.Find(id);
            db.TechLists.Remove(techList);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
