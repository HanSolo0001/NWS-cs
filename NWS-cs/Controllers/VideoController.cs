﻿using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace NWS_cs.Controllers
{
    public class VideoController : Controller
    {
        private NwsContext db = new NwsContext();

        public ActionResult _EditButtonPartial()
        {
            return PartialView();
        }

        // GET: Video
        public ActionResult Content()
        {
            return View(db.Videos.ToList());
        }

        // GET: Video/Create
        public ActionResult Create()
        {
            var model = new Video();
            return View(model);
        }

        // POST: Video/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "id,site,type,title,description,link")] Video video)
        {
            if (ModelState.IsValid)
            {
                db.Videos.Add(video);
                db.SaveChanges();
                return RedirectToAction("Content");
            }

            return View(video);
        }

        // GET: Video/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Video video = db.Videos.Find(id);
            if (video == null)
            {
                return HttpNotFound();
            }
            return View(video);
        }

        // POST: Video/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "id,site,type,title,description,link")] Video video)
        {
            if (ModelState.IsValid)
            {
                db.Entry(video).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Content");
            }
            return View(video);
        }

        // GET: Video/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Video video = db.Videos.Find(id);
            if (video == null)
            {
                return HttpNotFound();
            }
            return View(video);
        }

        // POST: Video/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Video video = db.Videos.Find(id);
            db.Videos.Remove(video);
            db.SaveChanges();
            return RedirectToAction("Content");
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
