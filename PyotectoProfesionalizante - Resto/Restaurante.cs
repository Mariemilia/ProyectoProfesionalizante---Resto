using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PyotectoProfesionalizante___Resto
{
   public class Restaurante
    {
        [Key]
        public String IdResto { get; set; }
        public String Direccion { get; set; }
        public List<Mesa> Mesas { get; set; }
        public List<Reserva> RegistroReservas { get; set; }
        public List<Comensal> Clientes { get; set; }

        public Restaurante(string Id, string Direc, List<Mesa> M, List<Reserva> Registro, List<Comensal> Cli)
        {
            IdResto = Id;
            Direccion = Direc;
            Mesas = M;
            RegistroReservas = Registro;
            Clientes = Cli;
        }
    }
}
