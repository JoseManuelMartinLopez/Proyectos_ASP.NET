using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoMVC4conBD.Models;

namespace ProyectoMVC4conBD.Controllers
{
    public class CargoController : Controller
    {
        // GET: Cargo

        bd_escuelaEntities entidad = new bd_escuelaEntities();
        public ActionResult Index()
        {
            var listacargos = entidad.cargo;
            return View(listacargos.ToList());
        }

        public ActionResult ListadoMaestraCargos()
        {
            var listacargos = entidad.cargo;
            return View(listacargos.ToList());
        }

        public ActionResult UsuarioxCargo(string cargo)
        {
            var modelo = from p in entidad.usuario where p.cargo.car_des == cargo select p;
            return View(modelo.ToList());
        }

        public ActionResult ListadoUsuarioconDescripcionCargo()
        {
            var modelo = from u in entidad.usuario
                         join c in entidad.cargo
                              on u.car_cod equals c.car_cod

                         select new EIUsuario
                         {
                             codigo = u.usu_cod,
                             nombre = u.usu_nom,
                             cargo = c.car_des
                         };
            return View(modelo.ToList());
        }
    }
}