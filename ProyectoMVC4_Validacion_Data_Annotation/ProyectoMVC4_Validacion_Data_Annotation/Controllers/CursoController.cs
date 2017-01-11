using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoMVC4_Validacion_Data_Annotation.Models;

namespace ProyectoMVC4_Validacion_Data_Annotation.Controllers
{
    public class CursoController : Controller
    {
        // GET: Curso

        bd_validarEntities bd = new bd_validarEntities();
        public ActionResult Index()
        {
            return View(bd.Curso.ToList());
        }

        public ActionResult CrearCurso()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CrearCurso(Curso curso)
        {
            if (ModelState.IsValid)
            {
                bd.Curso.Add(curso);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }else
            {
                return View(curso);
            }
            
        }
    }
}