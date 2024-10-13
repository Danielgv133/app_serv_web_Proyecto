using app_Serv_web_proyecto_1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace app_Serv_web_proyecto_1.Clases
{
    public class clsCliente
    {
        proyecto_app_servicios_webEntities1 proyecto_Entities1 = new proyecto_app_servicios_webEntities1();


        //Propiedad de tipo cliente que recibe como parámetro de entrada.

        public Cliente cliente { get; set; }
        public string Insertar()
        {
            try
            {
                proyecto_Entities1.Clientes.Add(cliente);
                proyecto_Entities1.SaveChanges();
                return "Se grabo el primer cliente" + cliente.nombre;

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
                proyecto_Entities1.Clientes.AddOrUpdate(cliente);
                proyecto_Entities1.SaveChanges();
                return "Se actualizo el cliente " + cliente.nombre;



            }
            catch (Exception ex)
            {

                return ex.Message;

            }
        }


        public Cliente Consultar(string documento)
        {
            return proyecto_Entities1.Clientes.FirstOrDefault(c => c.idcliente == cliente.idcliente);
        }

        public string Eliminar()
        {
            Cliente _cliente = Consultar(cliente.idcliente);
            proyecto_Entities1.Clientes.Remove(_cliente);
            proyecto_Entities1.SaveChanges();
            return "Se eliminó al usuario " + cliente.idcliente;
        }




    }
}