using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using thatsmyareacode.Models;

namespace thatsmyareacode.Controllers
{
    public class ZingersController : Controller
    {
        private ZingerDBContext db = new ZingerDBContext();

        // GET: Zingers
        public ActionResult Index(string zingerGenre, string searchString, string zingerAreaCode)
        {
            //var GenreLst = new List<string>();

            //GenreLst.Add("Humor");
            //GenreLst.Add("News");
            //GenreLst.Add("Popular");
            //GenreLst.Add("Random");
            //GenreLst.Add("Romance");
            //GenreLst.Add("Sports");        

            //var GenreQyr = from d in db.Zingers
            //               orderby d.Genre
            //               select d.Genre;

            /*GenreLst.AddRange(GenreQyr.Distinct());*/
            //ViewBag.zingerGenre = new SelectList(GenreLst);

            var zingers = from z in db.Zingers
                          select z;

            if (!String.IsNullOrEmpty(searchString))
            {
                zingers = zingers.Where(s => s.ZingerUserName.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(zingerAreaCode))
            {
                zingers = zingers.Where(s => s.AreaCode.Contains(zingerAreaCode));
            }

            if (!string.IsNullOrEmpty(zingerGenre))
            {
                zingers = zingers.Where(x => x.Genre == zingerGenre);
            }

            //if(!string.IsNullOrEmpty(zingerGenre))
            //{
            //    zingers = zingers.Where(x => x.Genre == zingerGenre);
            //}
            

            return View(zingers);
        }

        // GET: Zingers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zinger zinger = db.Zingers.Find(id);
            if (zinger == null)
            {
                return HttpNotFound();
            }
            return View(zinger);
        }

    

        // GET: Zingers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Zingers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ZingerID,ZingerMessage,ZingerImage,ZingerUserName,Genre,AreaCode,UpVote,DownVote,Favorite,TimeCreated")] Zinger zinger)
        {
            if (ModelState.IsValid)
            {
                db.Zingers.Add(zinger);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(zinger);
        }

        // GET: Zingers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zinger zinger = db.Zingers.Find(id);
            if (zinger == null)
            {
                return HttpNotFound();
            }
            return View(zinger);
        }

        // POST: Zingers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ZingerID,ZingerMessage,ZingerImage,ZingerUserName,Genre,AreaCode,UpVote,DownVote,Favorite,TimeCreated")] Zinger zinger)
        {
            if (ModelState.IsValid)
            {
                db.Entry(zinger).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(zinger);
        }

        // GET: Zingers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zinger zinger = db.Zingers.Find(id);
            if (zinger == null)
            {
                return HttpNotFound();
            }
            return View(zinger);
        }

        // POST: Zingers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Zinger zinger = db.Zingers.Find(id);
            db.Zingers.Remove(zinger);
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
