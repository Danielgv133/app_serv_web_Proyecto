using app_Serv_web_proyecto_1.Clases;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace app_Serv_web_proyecto_1.Controllers
{
    [EnableCors(origins: "https://localhost:44327", headers: "*", methods: "*")]
    [RoutePrefix("api/Clientes")]
    public class ClienteController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public ParqueDiversione Consultar(string idcliente)
        {
            clsCliente _cliente = new clsCliente();
            return _cliente.Consultar(idcliente);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] app_Serv_web_proyecto_1 cliente)
        {
            clsCliente _cliente = new clsCliente();
            _cliente.cliente = cliente;
            return _cliente.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] app_Serv_web_proyecto_1 cliente)
        {
            clsCliente _cliente = new clsCliente();
            _cliente.cliente = cliente;
            return _cliente.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] app_Serv_web_proyecto_1 cliente)
        {
            clsCliente _cliente = new clsCliente();
            _cliente.cliente = cliente;
            return _cliente.Eliminar();
        }

    }
}