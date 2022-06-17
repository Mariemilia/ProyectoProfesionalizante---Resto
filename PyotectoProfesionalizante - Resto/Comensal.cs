using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PyotectoProfesionalizante___Resto
{
    public class Comensal
    { 
        public String Apellido { get; set; }

        [Display(Name = "DNI: ")]
        [System.ComponentModel.DataAnnotations.Key]
        public int IdComensal { get; set; }
        [Display(Name = "N° de contacto: ")]
        public int NroCelular { get; set; }
        [Display(Name = "E-mail de contacto: ")]
        public String Email { get; set; }
        public Reserva Reserva { get; set; }

    }
}
