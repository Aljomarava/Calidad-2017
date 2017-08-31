using Domain;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Mvc5.Controllers
{
    public class DocumentosController : Controller
    {
        // GET: Documentos
        private IAlumnoService _alumnoService;
        private IDocumentoService _docuementosService;
        public DocumentosController()
        {
            if (_alumnoService == null)
            {
                _alumnoService = new AlumnoService();
            }
            if (_docuementosService==null)
            {
                _docuementosService = new DocumentoService();
            }

        }
        public ActionResult Index(string criterio)
        {
            var doc = _docuementosService.GetDocumentos(criterio);
            var alu = _docuementosService.GetDocumentos();
            return View(doc);
        }

        // GET: Documentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var doc = _docuementosService.GetAlumnooById(id);
            if (doc == null)
            {
                return HttpNotFound();
            }
            return View(doc);
        }

        // GET: Documentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Documentos/Create
        [HttpPost]
        public ActionResult Create(Documentos documentos)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    _docuementosService.AddDocumento(documentos);
                   


                    return RedirectToAction("Index");
                }
                return View(documentos);
            }
            catch
            {
                return View();
            }
        }

        // GET: Documentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var doc = _docuementosService.GetAlumnooById(id);
            if (doc == null)
            {
                return HttpNotFound();
            }
            return View(doc);
        }

        // POST: Documentos/Edit/5
        [HttpPost]
        public ActionResult Edit(Documentos documentos)
        {
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    _docuementosService.EditarDocumento(documentos);
                    

                    return RedirectToAction("Index");
                }
                return View(documentos);
            }
            catch
            {
                return View();
            }
        }

        // GET: Documentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var doc = _docuementosService.GetAlumnooById(id);
            if (doc == null)
            {
                return HttpNotFound();
            }
            return View(doc);
        }

        // POST: Documentos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                if (ModelState.IsValid)
                {
                    _docuementosService.EliminarDocumento(id);
                 


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
