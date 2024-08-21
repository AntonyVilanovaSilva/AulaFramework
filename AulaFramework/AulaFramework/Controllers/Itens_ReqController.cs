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
    public class Itens_ReqController : Controller
    {
        private xAlmoxarifadoEntities18 db = new xAlmoxarifadoEntities18();

        // GET: Itens_Req
        public ActionResult Index()
        {
            return View(db.ITENS_REQ.ToList());
        }

        // GET: Itens_Req/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ITENS_REQ iTENS_REQ = db.ITENS_REQ.Find(id);
            if (iTENS_REQ == null)
            {
                return HttpNotFound();
            }
            return View(iTENS_REQ);
        }

        // GET: Itens_Req/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Itens_Req/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NUM_ITEM,ID_PRO,ID_REQ,ID_SEC,QTD_PRO,PRE_UNIT,TOTAL_ITEM,TOTAL_REAL")] ITENS_REQ iTENS_REQ)
        {
            if (ModelState.IsValid)
            {
                db.ITENS_REQ.Add(iTENS_REQ);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(iTENS_REQ);
        }

        // GET: Itens_Req/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ITENS_REQ iTENS_REQ = db.ITENS_REQ.Find(id);
            if (iTENS_REQ == null)
            {
                return HttpNotFound();
            }
            return View(iTENS_REQ);
        }

        // POST: Itens_Req/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NUM_ITEM,ID_PRO,ID_REQ,ID_SEC,QTD_PRO,PRE_UNIT,TOTAL_ITEM,TOTAL_REAL")] ITENS_REQ iTENS_REQ)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iTENS_REQ).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iTENS_REQ);
        }

        // GET: Itens_Req/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ITENS_REQ iTENS_REQ = db.ITENS_REQ.Find(id);
            if (iTENS_REQ == null)
            {
                return HttpNotFound();
            }
            return View(iTENS_REQ);
        }

        // POST: Itens_Req/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ITENS_REQ iTENS_REQ = db.ITENS_REQ.Find(id);
            db.ITENS_REQ.Remove(iTENS_REQ);
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
