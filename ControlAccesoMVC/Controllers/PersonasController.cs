using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ControlAccesoMVC.Models;

namespace ControlAccesoMVC.Controllers
{
    [Authorize]
    public class PersonasController : Controller
    {
        private ModelControlAcceso db = new ModelControlAcceso();        
        // GET: Personas
        public ActionResult Index()
        {
            return View(db.CA_Personas.ToList());
        }

        // GET: Personas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CA_Personas cA_Personas = db.CA_Personas.Find(id);
            if (cA_Personas == null)
            {
                return HttpNotFound();
            }
            return View(cA_Personas);
        }

        // GET: Personas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombres,PrimerApellido,SegundoApellido,FechaRegistro,FechaBaja,Activo")] CA_Personas cA_Personas)
        {
            if (ModelState.IsValid)
            {
                db.CA_Personas.Add(cA_Personas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cA_Personas);
        }

        // GET: Personas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CA_Personas cA_Personas = db.CA_Personas.Find(id);
            if (cA_Personas == null)
            {
                return HttpNotFound();
            }
            return View(cA_Personas);
        }

        // POST: Personas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombres,PrimerApellido,SegundoApellido,FechaRegistro,FechaBaja,Activo")] CA_Personas cA_Personas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cA_Personas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cA_Personas);
        }

        // GET: Personas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CA_Personas cA_Personas = db.CA_Personas.Find(id);
            if (cA_Personas == null)
            {
                return HttpNotFound();
            }
            return View(cA_Personas);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            CA_Personas cA_Personas = db.CA_Personas.Find(id);
            db.CA_Personas.Remove(cA_Personas);
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
