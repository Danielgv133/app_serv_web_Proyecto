//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace app_Serv_web_proyecto_1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reserva
    {
        public string idreserva { get; set; }
        public Nullable<System.DateTime> fecha_reserva { get; set; }
        public string idcliente { get; set; }
        public string idempleado { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
