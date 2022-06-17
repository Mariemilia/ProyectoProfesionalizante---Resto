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
        [Key]
        public int IdComensal { get; set; }
        [Display(Name = "N° de contacto: ")]
        public int NroCelular { get; set; }
        [Display(Name = "E-mail de contacto: ")]
        public String Email { get; set; }
        public Reserva Reserva { get; set; }

        public Comensal(String ApellidoC, int IdC, int NroTel, String EmailC, Reserva R)
        {
            Apellido = ApellidoC;
            IdComensal = IdC;
            NroCelular = NroTel;
            Email = EmailC;
            Reserva = R;
        }
    }
}
