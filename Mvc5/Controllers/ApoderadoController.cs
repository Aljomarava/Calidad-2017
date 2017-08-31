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
    public class ApoderadoController : Controller
    {

        private IApoderadoService _apoderadoService;
        private IUbigeoService _ubigeoService;
        public ApoderadoController()
        {
            if (_apoderadoService==null )
            {
                _apoderadoService = new ApoderadosService();

            }
            if (_ubigeoService==null)
            {
                _ubigeoService = new UbigeoService();
            }
        }
        // GET: Apoderado
        public ActionResult Index(string criterio)
        {
            var ap = _apoderadoService.GetApoderados(criterio);
            var ub = _ubigeoService.GetUbigeos();
            ViewBag.ubigeo = new SelectList(ub, "UbigeoId", "Codigo", " Departamento ", "Provincia", "Distrito", "PaisId");
            
            return View(ap);
        }

        // GET: Apoderado/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ap = _apoderadoService.GetApoderadoById(id);
            if (ap == null)
            {
                return HttpNotFound();
            }
            return View(ap);
        }

        // GET: Apoderado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Apoderado/Create
        [HttpPost]
        public ActionResult Create(Apoderado apoderado)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _apoderadoService.AddApoderado(apoderado);


                    return RedirectToAction("Index");
                }
                return View(apoderado);
            }
            catch
            {
                return View();
            }
        }

        // GET: Apoderado/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ap = _apoderadoService.GetApoderadoById(id);
           
            if (ap == null)
            {
                return HttpNotFound();
            }
            return View(ap);
            
        }

        // POST: Apoderado/Edit/5
        [HttpPost]
        public ActionResult Edit(Apoderado apoderado)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    _apoderadoService.EditarApoderado(apoderado);
                    return RedirectToAction("Index");
                }
                return View(apoderado);
            }
            catch
            {
                return View();
            }
        }

        // GET: Apoderado/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ap = _apoderadoService.GetApoderadoById(id);

            if (ap == null)
            {
                return HttpNotFound();
            }
            return View(ap);

           
        }

        // POST: Apoderado/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                if (ModelState.IsValid)
                {
                    _apoderadoService.EliminarApoderado(id);

                    return RedirectToAction("Index");
                }
                return View(id);
            }
            catch
            {
                return View();
            }
        }
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
               
        //    }
        //    base.Dispose(disposing);
        //}

    }
}
