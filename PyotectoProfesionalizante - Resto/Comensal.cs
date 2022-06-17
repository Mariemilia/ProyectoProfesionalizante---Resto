using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PyotectoProfesionalizante___Resto
{
    public class Comensal
    { 
        public String Apellido { get; set; }
        [Key]
        public int IdComensal { get; set; }
        public int NroCelular { get; set; }
        public String Email { get; set; }
        public Reserva Reserva { get; set; }

    }
}
