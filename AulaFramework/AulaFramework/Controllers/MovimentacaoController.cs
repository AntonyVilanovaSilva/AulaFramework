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
    public class MovimentacaoController : Controller
    {
        private xAlmoxarifadoEntities19 db = new xAlmoxarifadoEntities19();

        // GET: Movimentacao
        public ActionResult Index()
        {
            return View(db.MOVIMENTACAO.ToList());
        }

        // GET: Movimentacao/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOVIMENTACAO mOVIMENTACAO = db.MOVIMENTACAO.Find(id);
            if (mOVIMENTACAO == null)
            {
                return HttpNotFound();
            }
            return View(mOVIMENTACAO);
        }

        // GET: Movimentacao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movimentacao/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_MOVI,ID_PRO,ID_SEC,ID_REQ,ID_NOTA,PRE_UNIT,QTD_PRO,SALDO,EST_ANT,TIPO_MOV,MES_MOV,ANO_MOV,DATA_MOV,ID_SET")] MOVIMENTACAO mOVIMENTACAO)
        {
            if (ModelState.IsValid)
            {
                db.MOVIMENTACAO.Add(mOVIMENTACAO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mOVIMENTACAO);
        }

        // GET: Movimentacao/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOVIMENTACAO mOVIMENTACAO = db.MOVIMENTACAO.Find(id);
            if (mOVIMENTACAO == null)
            {
                return HttpNotFound();
            }
            return View(mOVIMENTACAO);
        }

        // POST: Movimentacao/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_MOVI,ID_PRO,ID_SEC,ID_REQ,ID_NOTA,PRE_UNIT,QTD_PRO,SALDO,EST_ANT,TIPO_MOV,MES_MOV,ANO_MOV,DATA_MOV,ID_SET")] MOVIMENTACAO mOVIMENTACAO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mOVIMENTACAO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mOVIMENTACAO);
        }

        // GET: Movimentacao/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOVIMENTACAO mOVIMENTACAO = db.MOVIMENTACAO.Find(id);
            if (mOVIMENTACAO == null)
            {
                return HttpNotFound();
            }
            return View(mOVIMENTACAO);
        }

        // POST: Movimentacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MOVIMENTACAO mOVIMENTACAO = db.MOVIMENTACAO.Find(id);
            db.MOVIMENTACAO.Remove(mOVIMENTACAO);
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
