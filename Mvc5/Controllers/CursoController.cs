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
    public class CursoController : Controller
    {
        private ICursoService _cursoService;
        public CursoController()
        {
            if (_cursoService==null)
            {
                _cursoService = new CursoService();

            }
        }
        // GET: Curso
        public ActionResult Index(string criterio)
        {
            var cur = _cursoService.GetCurso(criterio);
            return View(cur);
        }

        // GET: Curso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var cur = _cursoService.GetCursoById(id);
            
            if (cur == null)
            {
                return HttpNotFound();
            }
            return View(cur);
        }

        // GET: Curso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Curso/Create
        [HttpPost]
        public ActionResult Create(Curso curso, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    _cursoService.AddCurso(curso);
                   

                    return RedirectToAction("Index");
                }
                return View(curso);
            }
            catch
            {
                return View();
            }
        }

        // GET: Curso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var cur = _cursoService.GetCursoById(id);

            if (cur == null)
            {
                return HttpNotFound();
            }
            return View(cur);
        }

        // POST: Curso/Edit/5
        [HttpPost]
        public ActionResult Edit(Curso curso, int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    _cursoService.EditarCurso(curso);
                  
                    return RedirectToAction("Index");
                }
                return View(curso);
            }
            catch
            {
                return View();
            }
        }

        // GET: Curso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var cur = _cursoService.GetCursoById(id);

            if (cur == null)
            {
                return HttpNotFound();
            }
            return View(cur);
        }

        // POST: Curso/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                if (ModelState.IsValid)
                {
                    _cursoService.EliminarCurso(id);
                    


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
