using app_Serv_web_proyecto_1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace app_Serv_web_proyecto_1.Clases
{
    public class clsEmpleado
    {
        proyecto_app_servicios_webEntities1 proyecto_Entities1 = new proyecto_app_servicios_webEntities1();

        public Empleado empleado { get; set; }

        public string Insertar()
        {
            try
            {
                proyecto_Entities1.Empleadoes.Add(empleado);
                proyecto_Entities1.SaveChanges();
                return "Se añadio el empleado" + empleado.nombre;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                proyecto_Entities1.Empleadoes.AddOrUpdate(empleado);
                proyecto_Entities1.SaveChanges();
                return "El empleado se ha creado/Actualizado" + empleado.nombre;

            }
            catch (Exception ex)
            {
                return ex.Message;

            }


        }

        public Empleado Consultar(string documento)
        {
            return proyecto_Entities1.Empleadoes.FirstOrDefault(c => c.idempleado == empleado.idempleado);
        }

        public string Eliminar()
        {
            Empleado _empleado = Consultar(empleado.idempleado);
            proyecto_Entities1.Empleadoes.Remove(_empleado);
            proyecto_Entities1.SaveChanges();
            return "Se elimino el empleado " + _empleado.nombre;

        }


        public List<Empleado> LlenarCombo()
        {
            return proyecto_Entities1.Empleadoes    
                .ToList();
        }



    }
}