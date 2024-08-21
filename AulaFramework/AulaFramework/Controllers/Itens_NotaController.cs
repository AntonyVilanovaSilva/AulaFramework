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
    public class Itens_NotaController : Controller
    {
        private xAlmoxarifadoEntities17 db = new xAlmoxarifadoEntities17();

        // GET: Itens_Nota
        public ActionResult Index()
        {
            return View(db.ITENS_NOTA.ToList());
        }

        // GET: Itens_Nota/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ITENS_NOTA iTENS_NOTA = db.ITENS_NOTA.Find(id);
            if (iTENS_NOTA == null)
            {
                return HttpNotFound();
            }
            return View(iTENS_NOTA);
        }

        // GET: Itens_Nota/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Itens_Nota/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ITEM_NUM,ID_PRO,ID_NOTA,ID_SEC,QTD_PRO,PRE_UNIT,TOTAL_ITEM,EST_LIN")] ITENS_NOTA iTENS_NOTA)
        {
            if (ModelState.IsValid)
            {
                db.ITENS_NOTA.Add(iTENS_NOTA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(iTENS_NOTA);
        }

        // GET: Itens_Nota/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ITENS_NOTA iTENS_NOTA = db.ITENS_NOTA.Find(id);
            if (iTENS_NOTA == null)
            {
                return HttpNotFound();
            }
            return View(iTENS_NOTA);
        }

        // POST: Itens_Nota/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ITEM_NUM,ID_PRO,ID_NOTA,ID_SEC,QTD_PRO,PRE_UNIT,TOTAL_ITEM,EST_LIN")] ITENS_NOTA iTENS_NOTA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iTENS_NOTA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iTENS_NOTA);
        }

        // GET: Itens_Nota/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ITENS_NOTA iTENS_NOTA = db.ITENS_NOTA.Find(id);
            if (iTENS_NOTA == null)
            {
                return HttpNotFound();
            }
            return View(iTENS_NOTA);
        }

        // POST: Itens_Nota/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ITENS_NOTA iTENS_NOTA = db.ITENS_NOTA.Find(id);
            db.ITENS_NOTA.Remove(iTENS_NOTA);
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
