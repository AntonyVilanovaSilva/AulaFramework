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
    public class EstoqueController : Controller
    {
        private xAlmoxarifadoEntities15 db = new xAlmoxarifadoEntities15();

        // GET: Estoque
        public ActionResult Index()
        {
            return View(db.ESTOQUE.ToList());
        }

        // GET: Estoque/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ESTOQUE eSTOQUE = db.ESTOQUE.Find(id);
            if (eSTOQUE == null)
            {
                return HttpNotFound();
            }
            return View(eSTOQUE);
        }

        // GET: Estoque/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estoque/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_SEC,ID_PRO,QTD_PRO")] ESTOQUE eSTOQUE)
        {
            if (ModelState.IsValid)
            {
                db.ESTOQUE.Add(eSTOQUE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eSTOQUE);
        }

        // GET: Estoque/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ESTOQUE eSTOQUE = db.ESTOQUE.Find(id);
            if (eSTOQUE == null)
            {
                return HttpNotFound();
            }
            return View(eSTOQUE);
        }

        // POST: Estoque/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_SEC,ID_PRO,QTD_PRO")] ESTOQUE eSTOQUE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eSTOQUE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eSTOQUE);
        }

        // GET: Estoque/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ESTOQUE eSTOQUE = db.ESTOQUE.Find(id);
            if (eSTOQUE == null)
            {
                return HttpNotFound();
            }
            return View(eSTOQUE);
        }

        // POST: Estoque/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ESTOQUE eSTOQUE = db.ESTOQUE.Find(id);
            db.ESTOQUE.Remove(eSTOQUE);
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
