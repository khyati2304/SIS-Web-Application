using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using S2G7_SISAPP.Models;

namespace S2G7_SISAPP.Controllers
{
    public class StudyTermsController : Controller
    {
        private S2G7_SISDBEntities db = new S2G7_SISDBEntities();

        // GET: StudyTerms
        public ActionResult Index()
        {
            return View(db.StudyTerms.ToList());
        }

        // GET: StudyTerms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudyTerm studyTerm = db.StudyTerms.Find(id);
            if (studyTerm == null)
            {
                return HttpNotFound();
            }
            return View(studyTerm);
        }

        // GET: StudyTerms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudyTerms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Term_ID,Term_Name,Term_Start_Date,Term_End_Date,Term_Season,Term_Year")] StudyTerm studyTerm)
        {
            if (ModelState.IsValid)
            {
                db.StudyTerms.Add(studyTerm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studyTerm);
        }

        // GET: StudyTerms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudyTerm studyTerm = db.StudyTerms.Find(id);
            if (studyTerm == null)
            {
                return HttpNotFound();
            }
            return View(studyTerm);
        }

        // POST: StudyTerms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Term_ID,Term_Name,Term_Start_Date,Term_End_Date,Term_Season,Term_Year")] StudyTerm studyTerm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studyTerm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studyTerm);
        }

        // GET: StudyTerms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudyTerm studyTerm = db.StudyTerms.Find(id);
            if (studyTerm == null)
            {
                return HttpNotFound();
            }
            return View(studyTerm);
        }

        // POST: StudyTerms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudyTerm studyTerm = db.StudyTerms.Find(id);
            db.StudyTerms.Remove(studyTerm);
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
