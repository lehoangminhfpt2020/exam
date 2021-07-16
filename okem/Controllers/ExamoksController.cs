using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using okem.Datacontent;
using okem.Models;

namespace okem.Controllers
{
    public class ExamoksController : Controller
    {
        private Datacontext db = new Datacontext();

        // GET: Examoks
        public ActionResult Index()
        {
            return View(db.exams.ToList());
        }

        // GET: Examoks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Examok examok = db.exams.Find(id);
            if (examok == null)
            {
                return HttpNotFound();
            }
            return View(examok);
        }

        // GET: Examoks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Examoks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Subject,StartTime,ExamDate,Duration,ClassRoom,Faculty,Status")] Examok examok)
        {
            if (ModelState.IsValid)
            {
                db.exams.Add(examok);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(examok);
        }

        // GET: Examoks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Examok examok = db.exams.Find(id);
            if (examok == null)
            {
                return HttpNotFound();
            }
            return View(examok);
        }

        // POST: Examoks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Subject,StartTime,ExamDate,Duration,ClassRoom,Faculty,Status")] Examok examok)
        {
            if (ModelState.IsValid)
            {
                db.Entry(examok).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(examok);
        }

        // GET: Examoks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Examok examok = db.exams.Find(id);
            if (examok == null)
            {
                return HttpNotFound();
            }
            return View(examok);
        }

        // POST: Examoks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Examok examok = db.exams.Find(id);
            db.exams.Remove(examok);
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
