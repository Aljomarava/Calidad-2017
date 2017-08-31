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
    public class GradosController : Controller
    {
        // GET: Grados
        private INivelService _nivelService;
        private IGradoService _gradoService;
        public GradosController()
        {
            if (_nivelService==null)
            {
                _nivelService = new NivelService();

            }
            if (_gradoService==null)
            {
                _gradoService = new GradoService();
            }
            
        }
        public ActionResult Index(string criterio, Int32? nivel)
        {
            var gr = _gradoService.GetGrado(criterio,nivel);
            var ni = _nivelService.GetNiveles();
            ViewBag.nivel = new SelectList(ni, "NivelId", "Nombre");
            return View(gr);
        }

        // GET: Grados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var gr = _gradoService.GetGradoById(id);
            if (gr == null)
            {
                return HttpNotFound();
            }
            return View(gr);
        }

        // GET: Grados/Create
        public ActionResult Create()
        {
            var ni = _nivelService.GetNiveles();
            ViewBag.nivel = new SelectList(ni, "NivelId", "Nombre");
            return View();
        }

        // POST: Grados/Create
        [HttpPost]
        public ActionResult Create(Grado grado)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _gradoService.AddGrado(grado);
                    
                    return RedirectToAction("Index");
                }
                return View(grado);
            }
            catch
            {
                return View();
            }
        }

        // GET: Grados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var gr = _gradoService.GetGradoById(id);
            var ni = _nivelService.GetNiveles();
            ViewBag.nivel = new SelectList(ni, "NivelId", "Nombre");
            if (gr == null)
            {
                return HttpNotFound();
            }
            return View(gr);
        }

        // POST: Grados/Edit/5
        [HttpPost]
        public ActionResult Edit(Grado grado)
        {
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    _gradoService.EditarGrado(grado);
                    
                    return RedirectToAction("Index");
                }
                return View(grado);
            }
            catch
            {
                return View();
            }
        }

        // GET: Grados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var gr = _gradoService.GetGradoById(id);
            
            if (gr == null)
            {
                return HttpNotFound();
            }
            return View(gr);
        }

        // POST: Grados/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                if (ModelState.IsValid)
                {
                    _gradoService.EliminarGrado(id);
                    

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
