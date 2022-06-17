using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PyotectoProfesionalizante___Resto
{
   public class Mesa
    {
        [Key]
        public int IdMesa { get; set; }
        public int Capacidad { get; set; }
        public EstadoMesa EstadoM { get; set; }
    }
}
