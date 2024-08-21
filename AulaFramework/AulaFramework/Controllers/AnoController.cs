using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AulaFramework.Models;

namespace AulaFramework.Controllers
{
    public class AnoController : Controller
    {
        private xAlmoxarifadoEntities13 db = new xAlmoxarifadoEntities13();

        // GET: Ano
        public ActionResult Index()
        {
            return View(db.ANO.ToList());
        }

        // GET: Ano/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ANO aNO = db.ANO.Find(id);
            if (aNO == null)
            {
                return HttpNotFound();
            }
            return View(aNO);
        }

        // GET: Ano/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ano/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ANO1,ABERTO")] ANO aNO)
        {
            if (ModelState.IsValid)
            {
                db.ANO.Add(aNO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aNO);
        }

        // GET: Ano/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ANO aNO = db.ANO.Find(id);
            if (aNO == null)
            {
                return HttpNotFound();
            }
            return View(aNO);
        }

        // POST: Ano/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ANO1,ABERTO")] ANO aNO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aNO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aNO);
        }

        // GET: Ano/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ANO aNO = db.ANO.Find(id);
            if (aNO == null)
            {
                return HttpNotFound();
            }
            return View(aNO);
        }

        // POST: Ano/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ANO aNO = db.ANO.Find(id);
            db.ANO.Remove(aNO);
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
