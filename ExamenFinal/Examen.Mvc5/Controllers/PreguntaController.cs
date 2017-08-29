using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Examen.Domain;
using Examen.Service;
using Examen.Mvc5.Models;

namespace Examen.Mvc5.Controllers
{
    public class PreguntaController : Controller
    {

        private IPreguntaService _preguntaService;
        private IEvaluacionService _evaluacionService;
        private IOpcionService _opcionService;
        // GET: Pregunta
        public PreguntaController()
        {
            if (_evaluacionService == null)
            {
                _evaluacionService = new EvaluacionService();
            }

            if (_preguntaService == null)
            {
                _preguntaService = new PreguntaService();
            }

            if (_opcionService == null)
            {
                _opcionService = new OpcionService();
            }
        }

        public ActionResult Index(string criterio)
        {
            var evaluaciones = _evaluacionService.GetEvaluaciones(criterio);

            return View(evaluaciones);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
     //   [ValidateAntiForgeryToken]
        public ActionResult Create(Evaluacion evaluacion)
        {
            if (ModelState.IsValid)
            {
                _evaluacionService.AddEvaluacion(evaluacion);

                return RedirectToAction("Index");
            }

            return View(evaluacion);
        }

        public ActionResult AgregarPregunta(Int32 evaluacionId)
        {
            ViewBag.Evaluacion = _evaluacionService.GetEvaluacionById(evaluacionId);

            var pregunta = new Pregunta();
            pregunta.EvaluacionId = evaluacionId;
            pregunta.Opciones = new List<Opcion>();
            return View();
        }
        [HttpPost]
        public ActionResult AgregarPregunta(Pregunta model)
        {
            if (ModelState.IsValid)
            {
                _preguntaService.AddPregunta(model);
                return RedirectToAction("verPreguntas", new { evaluacionId = model.EvaluacionId });
            }
            return View(model);
        }

        public ActionResult verPreguntas(int evaluacionId)
        {
            var evaluacion =
                from e in _evaluacionService.GetEvaluaciones()
                join p in _preguntaService.GetPreguntas("") on e.Id equals p.EvaluacionId
                
                join o in _opcionService.GetOpciones() on p.Id equals o.PreguntaId
             
                into po
                from opc in po.DefaultIfEmpty()
                where e.Id == evaluacionId
                select e;
            return View(evaluacion.First());
        }


        public ActionResult EditarPregunta(int preguntaId)
        {
            var model = _preguntaService.GetPreguntaById(preguntaId);
            return View(model);
        }
        [HttpPost]
        public ActionResult EditarPregunta(Pregunta model)
        {
            if (ModelState.IsValid)
            {
                foreach (var opc in model.Opciones)
                {
                    opc.PreguntaId = model.Id;
                    _opcionService.EditarOpcion(opc);
                }
                _preguntaService.EditarPregunta(model);
                return RedirectToAction("verPreguntas", new { evaluacionId = model.EvaluacionId });
            }
            return View(model);
        }


        public ActionResult QuitarPregunta(int preguntaId)
        {
            return View(_preguntaService.GetPreguntaById(preguntaId));
        }
        [HttpPost]
        public ActionResult QuitarPregunta(Pregunta model, int preguntaId)
        {
            if (!ModelState.IsValid)
            {
                //var opciones = _opcionService.GetOpciones().Where(o => o.Id.Equals(preguntaId));
                // foreach (var opc in opciones)
                // {
                //     opc.PreguntaId = model.Id;
                //    _opcionService.EliminarOpcion(opc.Id);
                // }

                _preguntaService.EliminarPregunta(preguntaId);
                return RedirectToAction("verPreguntas", new { evaluacionId = model.EvaluacionId });
            }
            return View(model);
        }



    }
}