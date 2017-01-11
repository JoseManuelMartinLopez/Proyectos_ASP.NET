using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoMVC4.Models;
using System.Collections;

namespace ProyectoMVC4.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            List<Persona> lista = new List<Persona>();

            Persona per1 = new Persona();
            per1.Codigo = 1;
            per1.Nombre = "Jose";
            per1.Apellido = "Martin";
            lista.Add(per1);

            Persona per2 = new Persona();
            per2.Codigo = 2;
            per2.Nombre = "Veronica";
            per2.Apellido = "Barba";
            lista.Add(per2);

            return View(lista);
        }
    }
}