using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NejakaMapa.Models;

namespace NejakaMapa
{
    public class UdalostController : Controller
    {
        private NejakaMapaContext db = new NejakaMapaContext();

        // GET: Udalost
        public async Task<ActionResult> Index()
        {
            return View(await db.Udalosts.ToListAsync());
        }

        // GET: Udalost/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Udalost udalost = await db.Udalosts.FindAsync(id);
            if (udalost == null)
            {
                return HttpNotFound();
            }
            return View(udalost);
        }

        // GET: Udalost/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Udalost/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Datum,Poznamka")] Udalost udalost)
        {
            if (ModelState.IsValid)
            {
                udalost.Id = Guid.NewGuid();
                db.Udalosts.Add(udalost);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(udalost);
        }

        // GET: Udalost/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Udalost udalost = await db.Udalosts.FindAsync(id);
            if (udalost == null)
            {
                return HttpNotFound();
            }
            return View(udalost);
        }

        // POST: Udalost/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Datum,Poznamka")] Udalost udalost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(udalost).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(udalost);
        }

        // GET: Udalost/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Udalost udalost = await db.Udalosts.FindAsync(id);
            if (udalost == null)
            {
                return HttpNotFound();
            }
            return View(udalost);
        }

        // POST: Udalost/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            Udalost udalost = await db.Udalosts.FindAsync(id);
            db.Udalosts.Remove(udalost);
            await db.SaveChangesAsync();
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
