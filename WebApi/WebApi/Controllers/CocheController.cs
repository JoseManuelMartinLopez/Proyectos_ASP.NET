using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CocheController : ApiController
    {
        Coche[] coches = new Coche[]
        {
            new Coche { IDCoche=1,Marca="Ferrari",Modelo=2012},
            new Coche { IDCoche=2,Marca="Peugeot",Modelo=2013},
            new Coche { IDCoche=3,Marca="Renault",Modelo=2014}
        };

        public IEnumerable<Coche> GetAllCoche()
        {
            return coches;
        }

        public IHttpActionResult GetCoche(int id)
        {


            var coche = coches.FirstOrDefault((c) => c.IDCoche == id);
            if (coche != null)
            {
                return Ok(coche);
            }
            else
            {
                return NotFound();
            }
        }
    }

}

        

        
    

