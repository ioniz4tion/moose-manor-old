using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moose_Manor.Models;

namespace Moose_Manor.Controllers
{
    public class PeopleController : Controller
    {
		public ActionResult Guy()
		{
			ViewBag.Message = "";

			return View();
		}

		public ActionResult Ginger()
		{
			ViewBag.Message = "";

			return View();
		}

		public ActionResult Brian()
		{
			ViewBag.Message = "";

			return View();
		}

		public ActionResult Brandi()
		{
			ViewBag.Message = "";

			return View();
		}


        private PeopleContext db = new PeopleContext();

        //
        // GET: /People/

        public ActionResult Index()
        {
            return View(db.MooseManorDB.ToList());
        }

        //
        // GET: /People/Details/5

        public ActionResult Details(int id = 0)
        {
            People people = db.MooseManorDB.Find(id);
            if (people == null)
            {
                return HttpNotFound();
            }
            return View(people);
        }

        //
        // GET: /People/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /People/Create

        [HttpPost]
        public ActionResult Create(People people)
        {
            if (ModelState.IsValid)
            {
                db.MooseManorDB.Add(people);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(people);
        }

        //
        // GET: /People/Edit/5

        public ActionResult Edit(int id = 0)
        {
            People people = db.MooseManorDB.Find(id);
            if (people == null)
            {
                return HttpNotFound();
            }
            return View(people);
        }

        //
        // POST: /People/Edit/5

        [HttpPost]
        public ActionResult Edit(People people)
        {
            if (ModelState.IsValid)
            {
                db.Entry(people).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(people);
        }

        //
        // GET: /People/Delete/5

        public ActionResult Delete(int id = 0)
        {
            People people = db.MooseManorDB.Find(id);
            if (people == null)
            {
                return HttpNotFound();
            }
            return View(people);
        }

        //
        // POST: /People/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            People people = db.MooseManorDB.Find(id);
            db.MooseManorDB.Remove(people);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}