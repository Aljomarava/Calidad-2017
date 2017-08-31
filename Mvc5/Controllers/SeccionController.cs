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
    public class SeccionController : Controller
    {
        // GET: Seccion
        private INivelService _nivelService;
        private IGradoService _gradoService;
        private ISeccionService _seccionService;
        public SeccionController()
        {
            if (_nivelService == null)
            {
                _nivelService = new NivelService();

            }
            if (_gradoService == null)
            {
                _gradoService = new GradoService();
            }
            if (_seccionService==null)
            {
                _seccionService = new SeccionService();
            }
        }
        public ActionResult Index(string criterio, Int32? nivel, Int32? grado)
        {
            var sec = _seccionService.GetSeccion(criterio, nivel,grado);
            
            return View(sec);
        }

        // GET: Seccion/Details/5
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var sec = _seccionService.GetSeccionById(id);
            if (sec == null)
            {
                return HttpNotFound();
            }
            return View(sec);
        }

        // GET: Seccion/Create
        public ActionResult Create()
        {
            var sec = _seccionService.GetSeccion();
            return View();
        }

        // POST: Seccion/Create
        [HttpPost]
        public ActionResult Create(Seccion seccion, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    _seccionService.AddSeccion(seccion);
                   
                    return RedirectToAction("Index");
                }
                return View(seccion);
            }
            catch
            {
                return View();
            }
        }

        // GET: Seccion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var sec = _seccionService.GetSeccionById(id);
            if (sec == null)
            {
                return HttpNotFound();
            }
            return View(sec);
        }

        // POST: Seccion/Edit/5
        [HttpPost]
        public ActionResult Edit(Seccion seccion)
        {
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    _seccionService.EditarSeccion(seccion);
                    

                    return RedirectToAction("Index");
                }
                return View(seccion);
            }
            catch
            {
                return View();
            }
        }

        // GET: Seccion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var sec = _seccionService.GetSeccionById(id);
            if (sec == null)
            {
                return HttpNotFound();
            }
            return View(sec);
        }

        // POST: Seccion/Delete/5
        [HttpPost]
        public ActionResult Delete( int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                if (ModelState.IsValid)
                {
                    _seccionService.EliminarSeccion(id);
                     
                    


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
