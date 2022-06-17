using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PyotectoProfesionalizante___Resto
{
   public class Restaurante
    {
        [Key]
        public int IdResto { get; set; }
        public String Direccion { get; set; }
        public List<Mesa> Mesas { get; set; }
        public List<Reserva> RegistroReservas { get; set; }
        public List<Comensal> Clientes { get; set; }

        public Restaurante(int Id, String Direc)
        {
            IdResto = Id;
            Direccion = Direc;
            Mesas = new List<Mesa>();
            RegistroReservas = new List<Reserva>();
            Clientes = new List<Comensal>();
        }
    }
}
