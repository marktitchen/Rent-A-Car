using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Rent_A_Car.Models;

namespace Rent_A_Car.Controllers
{
    public class RentalController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Rental
        public ActionResult Index()
        {
            var rentals = db.Rentals.Include(r => r.Car).Include(r => r.Customer);
            return View(rentals.ToList());
        }

        // GET: Rental/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rental rental = db.Rentals.Find(id);
            if (rental == null)
            {
                return HttpNotFound();
            }
            return View(rental);
        }

        // GET: Rental/Create
        public ActionResult Create()
        {
            ViewBag.CarId = new SelectList(db.Cars, "Id", "CarRegNo");
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "FName");
            return View();
        }

        // POST: Rental/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Fee,RentalDate,ReturnDate,CarId,CustomerId")] Rental rental)
        {
            if (ModelState.IsValid)
            {
                db.Rentals.Add(rental);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CarId = new SelectList(db.Cars, "Id", "CarRegNo", rental.CarId);
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "FName", rental.CustomerId);
            return View(rental);
        }

        // GET: Rental/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rental rental = db.Rentals.Find(id);
            if (rental == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarId = new SelectList(db.Cars, "Id", "CarRegNo", rental.CarId);
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "FName", rental.CustomerId);
            return View(rental);
        }

        // POST: Rental/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Fee,RentalDate,ReturnDate,CarId,CustomerId")] Rental rental)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rental).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CarId = new SelectList(db.Cars, "Id", "CarRegNo", rental.CarId);
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "FName", rental.CustomerId);
            return View(rental);
        }

        // GET: Rental/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rental rental = db.Rentals.Find(id);
            if (rental == null)
            {
                return HttpNotFound();
            }
            return View(rental);
        }

        // POST: Rental/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rental rental = db.Rentals.Find(id);
            db.Rentals.Remove(rental);
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
