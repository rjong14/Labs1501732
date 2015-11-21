using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _1.MVCEntity.Models;

namespace _1.MVCEntity.Controllers
{
    public class PlaylistController : Controller
    {
        private SongDBContext db = new SongDBContext();

        // GET: Playlist
        public ActionResult Index(string songGenre, string searchString) {
            var GenreLst = new List<string>();
            var GenreQry = from d in db.Playlist orderby d.Genre select d.Genre;

            GenreLst.AddRange(GenreQry.Distinct());
            ViewBag.songGenre = new SelectList(GenreLst);

            var playlist = from so in db.Playlist select so;

            if (!String.IsNullOrEmpty(searchString)) {
                playlist = playlist.Where(s => s.Title.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(songGenre)) {
                playlist = playlist.Where(x => x.Genre == songGenre);
            }
            return View(playlist);
        }
        // GET: Playlist/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Song song = db.Playlist.Find(id);
            if (song == null)
            {
                return HttpNotFound();
            }
            return View(song);
        }

        // GET: Playlist/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: Playlist/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,ReleaseDate,Genre,Singer,SongWriter")] Song song) {
            if (ModelState.IsValid) {
                db.Playlist.Add(song);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(song);
        }

        // GET: Playlist/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Song song = db.Playlist.Find(id);
            if (song == null)
            {
                return HttpNotFound();
            }
            return View(song);
        }

        // POST: Playlist/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,ReleaseDate,Genre,Singer,SongWriter")] Song song)
        {
            if (ModelState.IsValid)
            {
                db.Entry(song).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(song);
        }

        // GET: Playlist/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Song song = db.Playlist.Find(id);
            if (song == null)
            {
                return HttpNotFound();
            }
            return View(song);
        }

        // POST: Playlist/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Song song = db.Playlist.Find(id);
            db.Playlist.Remove(song);
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
