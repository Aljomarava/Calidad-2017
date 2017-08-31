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
    public class AlumnoController : Controller
    {
        private IAlumnoService _alumnoService;

        private IUbigeoService _ubigeoService;
        public AlumnoController()
        {
            if (_alumnoService==null)
            {
                _alumnoService = new AlumnoService();
            }
            if (_ubigeoService == null)
            {
                _ubigeoService = new UbigeoService();
            }
        }
        // GET: Alumno
        public ActionResult Index(string criterio)
        {
            var al = _alumnoService.GetAlumnos(criterio);
            var ub= _ubigeoService.GetUbigeos();
            
            return View(al);
        }

        // GET: Alumno/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var al = _alumnoService.GetAlumnooById(id);
            if (al == null)
            {
                return HttpNotFound();
            }
            return View(al);
        }
    
     
        // GET: Alumno/Create
        public ActionResult Create(string codigo)
        {
            ViewBag.codigo = _ubigeoService.GetUbigeoByCodigo(codigo);
           
            var ub = _ubigeoService.GetUbigeos();
            ViewBag.departamento = new SelectList(ub,"Departamento", "Provincia", "Distrito");
            return View();
        }

        // POST: Alumno/Create
        [HttpPost]
        public ActionResult Create(Alumno alumno)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _alumnoService.AddAlumno(alumno);


                    return RedirectToAction("Index");
                }
                return View(alumno);
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumno/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var al= _alumnoService.GetAlumnooById(id);

            if (al == null)
            {
                return HttpNotFound();
            }
            return View(al);
        }

        // POST: Alumno/Edit/5
        [HttpPost]
        public ActionResult Edit(Alumno alumno)
        {
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    _alumnoService.EditarAlumno(alumno);
                    
                    return RedirectToAction("Index");
                }
                return View(alumno);
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumno/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var al = _alumnoService.GetAlumnooById(id);

            if (al == null)
            {
                return HttpNotFound();
            }
            return View(al);
        }

        // POST: Alumno/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                if (ModelState.IsValid)
                {
                    _alumnoService.EliminarAlumno(id);
                    

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
