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
    public class FornecedorController : Controller
    {
        private xAlmoxarifadoEntities16 db = new xAlmoxarifadoEntities16();

        // GET: Fornecedor
        public ActionResult Index()
        {
            return View(db.FORNECEDOR.ToList());
        }

        // GET: Fornecedor/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FORNECEDOR fORNECEDOR = db.FORNECEDOR.Find(id);
            if (fORNECEDOR == null)
            {
                return HttpNotFound();
            }
            return View(fORNECEDOR);
        }

        // GET: Fornecedor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fornecedor/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_FOR,FANTASIA,CNPJ,RESPONSAVEL,INS_MUNICIPAL,INS_ESTADUAL,ENDERECO,BAIRRO,UF,TELEFONE,FAX,EMAIL,CELULAR")] FORNECEDOR fORNECEDOR)
        {
            if (ModelState.IsValid)
            {
                db.FORNECEDOR.Add(fORNECEDOR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fORNECEDOR);
        }

        // GET: Fornecedor/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FORNECEDOR fORNECEDOR = db.FORNECEDOR.Find(id);
            if (fORNECEDOR == null)
            {
                return HttpNotFound();
            }
            return View(fORNECEDOR);
        }

        // POST: Fornecedor/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_FOR,FANTASIA,CNPJ,RESPONSAVEL,INS_MUNICIPAL,INS_ESTADUAL,ENDERECO,BAIRRO,UF,TELEFONE,FAX,EMAIL,CELULAR")] FORNECEDOR fORNECEDOR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fORNECEDOR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fORNECEDOR);
        }

        // GET: Fornecedor/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FORNECEDOR fORNECEDOR = db.FORNECEDOR.Find(id);
            if (fORNECEDOR == null)
            {
                return HttpNotFound();
            }
            return View(fORNECEDOR);
        }

        // POST: Fornecedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            FORNECEDOR fORNECEDOR = db.FORNECEDOR.Find(id);
            db.FORNECEDOR.Remove(fORNECEDOR);
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
