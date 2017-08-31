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
    public class UbigeoController : Controller
    {
        private IUbigeoService _ubigeoService;
        private IPaisService _paisService;
        public UbigeoController()
        {
            if (_ubigeoService==null)
            {
                _ubigeoService = new UbigeoService();
            }
            if (_paisService==null)
            {
                _paisService = new PaisService();
            }
        }
        // GET: Ubigeo
        public ActionResult Index(string criterio, Int32? pais)
        {
            var ub = _ubigeoService.GetUbigeos(criterio, pais);
            var paiss = _paisService.GetPaises();
            ViewBag.Pa= new SelectList(paiss, "PaisId", "Nombre");
            return View(ub);
        }

        // GET: Ubigeo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ub = _ubigeoService.GetUbigeoById(id);
            if (ub== null)
            {
                return HttpNotFound();
            }
            return View(ub);
        }

        // GET: Ubigeo/Create
        public ActionResult Create()
        {
            var ps = _paisService.GetPaises();
            ViewBag.Pais = new SelectList(ps, "PaisId", "Nombre");
            return View();
        }

        // POST: Ubigeo/Create
        [HttpPost]
        public ActionResult Create(Ubigeo ubigeo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _ubigeoService.AddUbigeo(ubigeo);
                    return RedirectToAction("Index");
                }
                return View(ubigeo);
                //var ps = _paisService.GetPaises();
                //ViewBag.Pais = new SelectList(ps, "PaisId", "Nombre");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ubigeo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ub = _ubigeoService.GetUbigeoById(id);
            var ps = _paisService.GetPaises();
            ViewBag.pas = new SelectList(ps, "PaisId", "Nombre");
            if (ub == null)
            {
                return HttpNotFound();
            }
            return View(ub);
        }

        // POST: Ubigeo/Edit/5
        [HttpPost]
        public ActionResult Edit(Ubigeo ubigeo)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    _ubigeoService.EditarUbigeo(ubigeo);
                    return RedirectToAction("Index");
                }
                return View(ubigeo);
            }
            catch
            {
                return View();
            }
        }

        // GET: Ubigeo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ub = _ubigeoService.GetUbigeoById(id);
            if (ub == null)
            {
                return HttpNotFound();
            }
            return View(ub);
        }

        // POST: Ubigeo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                if (ModelState.IsValid)
                {
                    _ubigeoService.EliminarUbigeo(id);

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
