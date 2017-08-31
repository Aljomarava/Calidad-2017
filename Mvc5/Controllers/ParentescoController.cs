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
    public class ParentescoController : Controller
    {
        // GET: Parentesco
        private IParentescoService _parentescoService;
        public ParentescoController()
        {
            if (_parentescoService==null)
            {
                _parentescoService = new ParentescoService();
            }
        }
        public ActionResult Index(string criterio)
        {
            var par = _parentescoService.GetParentescos(criterio);
            return View(par);
        }

        // GET: Parentesco/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var par = _parentescoService.GetParentescoById(id);
            if (par == null)
            {
                return HttpNotFound();
            }
            return View(par);
        }

        // GET: Parentesco/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parentesco/Create
        [HttpPost]
        public ActionResult Create(Parentesco parentesco, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    _parentescoService.AddParentesco(parentesco);
                    return RedirectToAction("Index");
                }
                return View(parentesco);
            }
            catch
            {
                return View();
            }
        }

        // GET: Parentesco/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var par = _parentescoService.GetParentescoById(id);
            if (par == null)
            {
                return HttpNotFound();
            }
            return View(par);
           
        }

        // POST: Parentesco/Edit/5
        [HttpPost]
        public ActionResult Edit(Parentesco parentesco)
        {
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    _parentescoService.EditarParentescos(parentesco);
                    return RedirectToAction("Index");
                }
                return View(parentesco);
            }
            catch
            {
                return View();
            }
        }

        // GET: Parentesco/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var par = _parentescoService.GetParentescoById(id);
            if (par == null)
            {
                return HttpNotFound();
            }
            return View(par);
        }

        // POST: Parentesco/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                if (ModelState.IsValid)
                {
                    _parentescoService.EliminarParentesco(id);

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
