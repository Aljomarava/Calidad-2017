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
    public class NivelController : Controller
    {
        // GET: Nivel
        private INivelService _nivelService;
        public NivelController()
        {
            if (_nivelService==null)
            {
                _nivelService = new NivelService();
            }
        }
        public ActionResult Index()
        {
            var ni = _nivelService.GetNiveles();
            return View(ni);
        }

        // GET: Nivel/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ni = _nivelService.GetNivelById(id);
            if (ni == null)
            {
                return HttpNotFound();
            }
            return View(ni);
        }

        // GET: Nivel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nivel/Create
        [HttpPost]
        public ActionResult Create(Nivel nivel)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    _nivelService.AddNivel(nivel);
                  
                    return RedirectToAction("Index");
                }
                return View(nivel);
            }
            catch
            {
                return View();
            }
        }

        // GET: Nivel/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ni = _nivelService.GetNivelById(id);
            if (ni == null)
            {
                return HttpNotFound();
            }
            return View(ni);
            
        }

        // POST: Nivel/Edit/5
        [HttpPost]
        public ActionResult Edit(Nivel nivel)
        {
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    _nivelService.EditarNivel(nivel);
                    return RedirectToAction("Index");
                }
                return View(nivel);
            }
            catch
            {
                return View();
            }
        }

        // GET: Nivel/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ni = _nivelService.GetNivelById(id);
            if (ni == null)
            {
                return HttpNotFound();
            }
            return View(ni);
           
        }

        // POST: Nivel/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                if (ModelState.IsValid)
                {
                    _nivelService.EliminarNivel(id);
                   

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
