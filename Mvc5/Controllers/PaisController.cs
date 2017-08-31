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
    public class PaisController : Controller
    {
        // GET: Pais

        private IPaisService _paiesService;
        public PaisController()
        {
            if (_paiesService==null)
            {
                _paiesService = new PaisService();
            }
        }
        public ActionResult Index(string criterio)
        {
            
            var ps= _paiesService.GetPaises(criterio);
            return View(ps);
        }

        // GET: Pais/Details/5
        public ActionResult Details(int? id)
        {
            if (id ==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ps = _paiesService.GetPaisById(id);
            if (ps == null)
            {
                return HttpNotFound();
            }
            return View(ps);
        }

       
        public ActionResult Create( )
        {
            return View();
        }

        // POST: Pais/Create
        [HttpPost]
        public ActionResult Create(Pais pais)
        {
            try
            {
                
                if (ModelState.IsValid)
                {
                    _paiesService.AddPais(pais);
                    return RedirectToAction("Index");
                }
                return View(pais);
            }
            catch
            {
                return View();
            }
        }

        // GET: Pais/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ps = _paiesService.GetPaisById(id);
            if (ps == null)
            {
                return HttpNotFound();
            }
            return View(ps);
           
        }

        // POST: Pais/Edit/5
        [HttpPost]
        public ActionResult Edit(Pais pais)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    _paiesService.EditarPais(pais);
                    return RedirectToAction("Index");
                }
                return View(pais);
                
            }
            catch
            {
                return View(pais);
            }
        }

        // GET: Pais/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ps = _paiesService.GetPaisById(id);
            if (ps == null)
            {
                return HttpNotFound();
            }
            return View(ps);
           
        }

        // POST: Pais/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here

                if (ModelState.IsValid)
                {
                    _paiesService.EliminarPais(id);
                   
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
