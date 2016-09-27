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
    public class SaleItemsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SaleItems
        public async Task<ActionResult> Index()
        {
            var saleItems = db.SaleItems.Include(s => s.SaleHeader);
            return View(await saleItems.ToListAsync());
        }

        // GET: SaleItems/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SaleItem saleItem = await db.SaleItems.FindAsync(id);
            if (saleItem == null)
            {
                return HttpNotFound();
            }
            return View(saleItem);
        }

        // GET: SaleItems/Create
        public ActionResult Create()
        {
            ViewBag.SaleHeaderId = new SelectList(db.SaleHeaders, "SaleHeaderId", "CustomerFirstName");
            return View();
        }

        // POST: SaleItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "SaleItemId,Title,Quantity,CostPerItem,SaleHeaderId")] SaleItem saleItem)
        {
            if (ModelState.IsValid)
            {
                db.SaleItems.Add(saleItem);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.SaleHeaderId = new SelectList(db.SaleHeaders, "SaleHeaderId", "CustomerFirstName", saleItem.SaleHeaderId);
            return View(saleItem);
        }

        // GET: SaleItems/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SaleItem saleItem = await db.SaleItems.FindAsync(id);
            if (saleItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.SaleHeaderId = new SelectList(db.SaleHeaders, "SaleHeaderId", "CustomerFirstName", saleItem.SaleHeaderId);
            return View(saleItem);
        }

        // POST: SaleItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "SaleItemId,Title,Quantity,CostPerItem,SaleHeaderId")] SaleItem saleItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(saleItem).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.SaleHeaderId = new SelectList(db.SaleHeaders, "SaleHeaderId", "CustomerFirstName", saleItem.SaleHeaderId);
            return View(saleItem);
        }

        // GET: SaleItems/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SaleItem saleItem = await db.SaleItems.FindAsync(id);
            if (saleItem == null)
            {
                return HttpNotFound();
            }
            return View(saleItem);
        }

        // POST: SaleItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SaleItem saleItem = await db.SaleItems.FindAsync(id);
            db.SaleItems.Remove(saleItem);
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
