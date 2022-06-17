using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PyotectoProfesionalizante___Resto
{
    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }
        [Display(Name = "Cantidad de mesas reservadas: ")]
        public int MesasReservadas { get; set; }
        /*[Display(Name = "Titular de la reserva: ")]
        public Comensal TitularReserva { get; set; }
        */
        [Display(Name = "Confirmación de la reserva: ")]
        [EnumDataType(typeof(EstadoReserva))]
        public EstadoReserva EstadoR { get; set; }
        [Display(Name = "Fecha y hora de la reserva: ")]
        public DateTime FechaReserva { get; set; }  
    }
}
