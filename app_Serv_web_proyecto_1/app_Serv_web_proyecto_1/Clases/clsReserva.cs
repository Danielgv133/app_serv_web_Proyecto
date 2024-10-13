using app_Serv_web_proyecto_1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace app_Serv_web_proyecto_1.Clases
{
    public class clsReserva
    {
        private proyecto_app_servicios_webEntities1 proyecto_Entities1 = new proyecto_app_servicios_webEntities1();

        public Reserva reserva { get; set; }

        public string Insertar()
        {
            try
            {
                proyecto_Entities1.Reservas.Add(reserva);
                proyecto_Entities1.SaveChanges();
                return " Se ingresó la reserva " + reserva.idreserva;
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
                proyecto_Entities1.Reservas.AddOrUpdate(reserva);
                proyecto_Entities1.SaveChanges();
                return "Se actualizó la reserva " + reserva.idreserva; 
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public Reserva Consultar(string idreserva)
        {
            return proyecto_Entities1.Reservas.FirstOrDefault(c => c.idreserva == reserva.idreserva);

        }

        public string Eliminar()
        {
            Reserva _reserva = Consultar(reserva.idreserva);
            proyecto_Entities1.Reservas.Remove(_reserva);
            proyecto_Entities1.SaveChanges ();
            return "Se eliminó " + _reserva.idreserva;

        }

        public IQueryable LlenarTabla()
        {
            
        }

    }
}