using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PyotectoProfesionalizante___Resto
{
    public class Reserva
    {
        [Key]
        public int NroReserva { get; set; }
        public List<Mesa> MesasReservadas { get; set; }
        public Comensal TitularReserva { get; set; }
        public EstadoReserva EstadoR { get; set; }
    }
}
