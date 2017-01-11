using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoMVC4_Validacion_Data_Annotation.Models;

namespace ProyectoMVC4_Validacion_Data_Annotation.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario

        private bd_validarEntities bd = new bd_validarEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Validar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Validar(string user, string password)
        {
            Usuario us = bd.Usuario.FirstOrDefault(d => d.usuario_u == user &  d.clave_u ==password);
            if (us != null)
            {
                return RedirectToAction("Index", "Curso");
            }
            else
            {
                return RedirectToAction("NoHallado", "Usuario");
            }
            
        }

        public ActionResult NoHallado()
        {
            ViewBag.Error = "No se encontró usuario con estos datos";
            return View();
        }
    }
}