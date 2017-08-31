using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Domain;
namespace Mvc5.Controllers
{
    public class DocenteController : Controller
    {
        // GET: Docente
        private IUbigeoService _ubigeoService;
        private IDocenteService _docenteService;
        public DocenteController()
        {
            if (_ubigeoService==null)
            {
                _ubigeoService = new UbigeoService();
            }
            if (_docenteService == null)
            {
                _docenteService = new DocenteService();
            }
        }
        public ActionResult Index(string criterio)
        {
            var doc = _docenteService.GetDocentes(criterio);
            var ub = _ubigeoService.GetUbigeos(); 
            return View(doc);
        }

        // GET: Docente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var doce = _docenteService.GetDocenteById(id);
         
            if (doce == null)
            {
                return HttpNotFound();
            }
            return View(doce);
        }

        // GET: Docente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Docente/Create
        [HttpPost]
        public ActionResult Create(Docente docente, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    _docenteService.AddDocente(docente);
                  


                    return RedirectToAction("Index");
                }
                return View(docente);
            }
            catch
            {
                return View();
            }
        }

        // GET: Docente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var doce = _docenteService.GetDocenteById(id);

            if (doce == null)
            {
                return HttpNotFound();
            }
            return View(doce);
        }

        // POST: Docente/Edit/5
        [HttpPost]
        public ActionResult Edit(Docente docente,int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    _docenteService.EditarDocente(docente);
                   

                    return RedirectToAction("Index");
                }
                return View(docente);
            }
            catch
            {
                return View();
            }
        }

        // GET: Docente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var doce = _docenteService.GetDocenteById(id);

            if (doce == null)
            {
                return HttpNotFound();
            }
            return View(doce);
        }

        // POST: Docente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                if (ModelState.IsValid)
                {
                    _docenteService.EliminarDocente(id);
                  


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
