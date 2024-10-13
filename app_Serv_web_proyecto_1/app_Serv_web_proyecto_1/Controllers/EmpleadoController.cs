using app_Serv_web_proyecto_1.Clases;
using app_Serv_web_proyecto_1.Models;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace app_Serv_web_proyecto_1.Controllers
{
    [RoutePrefix("api/Empleados")]
    public class EmpleadoController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public Empleado Consultar(string idempleado)
        {
            clsEmpleado _empleado= new clsEmpleado();
            return _empleado.Consultar(idempleado);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Empleado empleado)
        {
            clsEmpleado _empleado = new clsEmpleado();
            _empleado.empleado = empleado;
            return _empleado.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Empleado empleado)
        {
            clsEmpleado _empleado = new clsEmpleado();
            _empleado.empleado = empleado;
            return _empleado.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Empleado empleado)
        {
            clsEmpleado _empleado = new clsEmpleado();
            _empleado.empleado = empleado;
            return _empleado.Eliminar();
        }
    }
}