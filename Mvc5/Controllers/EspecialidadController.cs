using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service;
using Domain;
using System.Net;

namespace Mvc5.Controllers
{
    public class EspecialidadController : Controller
    {
        // GET: Especialidad
        private IEspecialidadService _especialidadService;
        public EspecialidadController()
        {
            if (_especialidadService==null)
            {
                _especialidadService = new EspecialidadService();
            }
        }
        public ActionResult Index(string criterio)
        {
            var esp = _especialidadService.GetEspecialidades(criterio);
            return View(esp);
        }

        // GET: Especialidad/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var esp = _especialidadService.GetEspecialidadById(id);
            
            if (esp == null)
            {
                return HttpNotFound();
            }
            return View(esp);
        }

        // GET: Especialidad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Especialidad/Create
        [HttpPost]
        public ActionResult Create(Especialidad especialidad, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    _especialidadService.AddEspecialidad(especialidad);
                 
                    return RedirectToAction("Index");
                }
                return View(especialidad);
            }
            catch
            {
                return View();
            }
        }

        // GET: Especialidad/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var esp = _especialidadService.GetEspecialidadById(id);

            if (esp == null)
            {
                return HttpNotFound();
            }
            return View(esp);
        }

        // POST: Especialidad/Edit/5
        [HttpPost]
        public ActionResult Edit(Especialidad especialidad)
        {
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    _especialidadService.EditarEspecialidad(especialidad);
                   
                    return RedirectToAction("Index");
                }
                return View(especialidad);
            }
            catch
            {
                return View();
            }
        }

        // GET: Especialidad/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var esp = _especialidadService.GetEspecialidadById(id);

            if (esp == null)
            {
                return HttpNotFound();
            }
            return View(esp); 
        }

        // POST: Especialidad/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                if (ModelState.IsValid)
                {
                    _especialidadService.EliminarEspecialidad(id);
                   

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
