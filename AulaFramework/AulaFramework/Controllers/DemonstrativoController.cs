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
    public class DemonstrativoController : Controller
    {
        private xAlmoxarifadoEntities14 db = new xAlmoxarifadoEntities14();

        // GET: Demonstrativo
        public ActionResult Index()
        {
            return View(db.DEMONSTRATIVO.ToList());
        }

        // GET: Demonstrativo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DEMONSTRATIVO dEMONSTRATIVO = db.DEMONSTRATIVO.Find(id);
            if (dEMONSTRATIVO == null)
            {
                return HttpNotFound();
            }
            return View(dEMONSTRATIVO);
        }

        // GET: Demonstrativo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Demonstrativo/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_GRU,NOME_GRU,ID_SUB_GRU,NOME_SUB_GRU,ID_CLA,NOME_CLA,ID_SEC,NOME_SEC,UNI_MED,ID_PRO,DESCRICAO_PRO,SALDO_ANTERIOR,SALDO_ANT_CUSTO,ENTRADA_QTD,ENTRADA_VL_UNIT,SAIDA_QTD,SAIDA_CM,SALDO_QTD,SALDO_CM")] DEMONSTRATIVO dEMONSTRATIVO)
        {
            if (ModelState.IsValid)
            {
                db.DEMONSTRATIVO.Add(dEMONSTRATIVO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dEMONSTRATIVO);
        }

        // GET: Demonstrativo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DEMONSTRATIVO dEMONSTRATIVO = db.DEMONSTRATIVO.Find(id);
            if (dEMONSTRATIVO == null)
            {
                return HttpNotFound();
            }
            return View(dEMONSTRATIVO);
        }

        // POST: Demonstrativo/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_GRU,NOME_GRU,ID_SUB_GRU,NOME_SUB_GRU,ID_CLA,NOME_CLA,ID_SEC,NOME_SEC,UNI_MED,ID_PRO,DESCRICAO_PRO,SALDO_ANTERIOR,SALDO_ANT_CUSTO,ENTRADA_QTD,ENTRADA_VL_UNIT,SAIDA_QTD,SAIDA_CM,SALDO_QTD,SALDO_CM")] DEMONSTRATIVO dEMONSTRATIVO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dEMONSTRATIVO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dEMONSTRATIVO);
        }

        // GET: Demonstrativo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DEMONSTRATIVO dEMONSTRATIVO = db.DEMONSTRATIVO.Find(id);
            if (dEMONSTRATIVO == null)
            {
                return HttpNotFound();
            }
            return View(dEMONSTRATIVO);
        }

        // POST: Demonstrativo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DEMONSTRATIVO dEMONSTRATIVO = db.DEMONSTRATIVO.Find(id);
            db.DEMONSTRATIVO.Remove(dEMONSTRATIVO);
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
