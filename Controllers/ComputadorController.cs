
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Parcial1.Models;
using Parcial1.Clases;
namespace apiCineClub.Controllers
{
    [RoutePrefix("api/Computadores")]
    public class ComputadoresController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Computador> ConsultarTodos()
        {
            clsOpeComputador computador = new clsOpeComputador();
            return computador.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXID")]
        public Computador ConsultarXID(int id)
        {
            clsOpeComputador computador = new clsOpeComputador();
            return computador.Consultar(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Computador computador)
        {
            clsOpeComputador opeComputador = new clsOpeComputador();
            opeComputador.computador = computador;
            return opeComputador.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Computador computador)
        {
            clsOpeComputador opeComputador = new clsOpeComputador();
            opeComputador.computador = computador;
            return opeComputador.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXID")]
        public string EliminarXID(int id)
        {
            clsOpeComputador opeComputador = new clsOpeComputador();
            return opeComputador.Eliminar(id);
        }
    }
}
