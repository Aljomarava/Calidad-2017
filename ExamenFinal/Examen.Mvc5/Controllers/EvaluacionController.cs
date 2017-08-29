using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Examen.Service;
using Examen.Domain;
using Examen.Mvc5.Models;

namespace Examen.Mvc5.Controllers
{
    public class EvaluacionController : Controller
    {
        private IPreguntaService _preguntaService;
        private IEvaluacionService _evaluacionService;
        private IOpcionService _opcionService;
                            
                                                     
        public EvaluacionController()
        {
            if (_evaluacionService == null)
            {
                _evaluacionService = new EvaluacionService();
            }

            if(_preguntaService == null)
            {
                _preguntaService = new PreguntaService();
            }

            if(_opcionService == null)
            {
                _opcionService = new OpcionService();
            }

           // _preguntaService = preguntaService;
            //_evaluacionService = evaluacionService;
            //_opcionService = opcionService;
        }

        // GET: Evaluacion
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
        [ValidateAntiForgeryToken]
        public ActionResult Create(Evaluacion evaluacion)
        {
            if (ModelState.IsValid)
            {
                _evaluacionService.AddEvaluacion(evaluacion);

                return RedirectToAction("Index");
            }
        
            return View(evaluacion);
        }


        public ActionResult AgregarPregunta()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AgregarPregunta(Pregunta pregunta)
        {
            if(ModelState.IsValid)
            {
                _preguntaService.AddPregunta(pregunta);
                return RedirectToAction("Index");
            }
            return View();
        }


        //public ActionResult Edit(Int32 evaluacionId)
        public ActionResult Edit()
        {
          //  var model = _evaluacionService.GetEvaluacionById(evaluacionId);

            return View();
        }

        public ActionResult VerPregunta()
        {
            var pregunta = _preguntaService.GetPreguntas();
            var opcion = _opcionService.GetOpciones();

            return View(pregunta);

        }

        public ActionResult VerPreguntaDos()
        {
            var pregunta = _preguntaService.GetPreguntas();
            var opcion = _opcionService.GetOpciones();

            return View(pregunta);

        }

        public ActionResult VerPreguntasJOINS(int evaluacionId)
        {
            var evaluacion =
                from e in _evaluacionService.GetEvaluaciones()
                join p in _preguntaService.GetPreguntas() on e.Id equals p.EvaluacionId

                join o in _opcionService.GetOpciones() on p.Id equals o.PreguntaId
                  
                into po
                from opc in po.DefaultIfEmpty()
                where e.Id == evaluacionId
                select e;

            //var loj = (from prsn in db.People
            //           join co in db.Companies on prsn.Person_ID equals co.Person_ID 
            //            into comps
            //            from y in comps.DefaultIfEmpty()
            //           join prod in db.Products on prsn.Person_ID equals prod.Person_ID
            //            into prods
            //            from x in prods.DefaultIfEmpty()
            //           select new { Person = prsn.NAME, Company = y.NAME, Product = x.NAME })

            return View(evaluacion.First());
        }




    }
}