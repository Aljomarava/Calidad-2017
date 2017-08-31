using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using Service;
using System.Net;

namespace Mvc5.Controllers
{
    public class EntregaDocumentosController : Controller
    {
        // GET: EntregaDocumentos
        private IEntregaDocumentosService _entregaService;
        public EntregaDocumentosController()
        {
            if (_entregaService==null)
            {
                _entregaService = new EntregaDocumentosService();
            }
        }
        public ActionResult Index()
        {
            var EDoc = _entregaService.GetEntregaDocuentos();
            return View(EDoc);
        }

        // GET: EntregaDocumentos/Details/5
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Edoc = _entregaService.GetEntregaDocuentosById(id);
           
            if (Edoc == null)
            {
                return HttpNotFound();
            }
            return View(Edoc);
        }

        // GET: EntregaDocumentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EntregaDocumentos/Create
        [HttpPost]
        public ActionResult Create(EntregaDocuentos entrega)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _entregaService.AddEntregaDocuentos(entrega);
                    
                    return RedirectToAction("Index");
                }
                return View(entrega);
            }
            catch
            {
                return View();
            }
        }

        // GET: EntregaDocumentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Edoc = _entregaService.GetEntregaDocuentosById(id);

            if (Edoc == null)
            {
                return HttpNotFound();
            }
            return View(Edoc);
        }

        // POST: EntregaDocumentos/Edit/5
        [HttpPost]
        public ActionResult Edit(EntregaDocuentos entrega)
        {
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    _entregaService.EditarEntregaDocuentos(entrega);
                    
                    return RedirectToAction("Index");
                }
                return View(entrega);
            }
            catch
            {
                return View();
            }
        }

        // GET: EntregaDocumentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Edoc = _entregaService.GetEntregaDocuentosById(id);

            if (Edoc == null)
            {
                return HttpNotFound();
            }
            return View(Edoc);
        }

        // POST: EntregaDocumentos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                if (ModelState.IsValid)
                {
                    _entregaService.EliminarEntregaDocuentos(id);
                    

                    return RedirectToAction("Index");
                }
                return View(id);
            }
            catch
            {
                return View();
            }
        }
    }
}
