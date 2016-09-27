using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JasmineTest.Models;

namespace JasmineTest.Controllers
{
    public class SaleHeadersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SaleHeaders
        public async Task<ActionResult> Index()
        {
            return View(await db.SaleHeaders.ToListAsync());
        }

        // GET: SaleHeaders/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SaleHeader saleHeader = await db.SaleHeaders.FindAsync(id);
            if (saleHeader == null)
            {
                return HttpNotFound();
            }
            return View(saleHeader);
        }

        // GET: SaleHeaders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SaleHeaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "SaleHeaderId,CustomerFirstName,CustomerSecondName,Address")] SaleHeader saleHeader)
        {
            if (ModelState.IsValid)
            {
                db.SaleHeaders.Add(saleHeader);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(saleHeader);
        }

        // GET: SaleHeaders/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SaleHeader saleHeader = await db.SaleHeaders.FindAsync(id);
            if (saleHeader == null)
            {
                return HttpNotFound();
            }
            return View(saleHeader);
        }

        // POST: SaleHeaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "SaleHeaderId,CustomerFirstName,CustomerSecondName,Address")] SaleHeader saleHeader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(saleHeader).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(saleHeader);
        }

        // GET: SaleHeaders/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SaleHeader saleHeader = await db.SaleHeaders.FindAsync(id);
            if (saleHeader == null)
            {
                return HttpNotFound();
            }
            return View(saleHeader);
        }

        // POST: SaleHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SaleHeader saleHeader = await db.SaleHeaders.FindAsync(id);
            db.SaleHeaders.Remove(saleHeader);
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
