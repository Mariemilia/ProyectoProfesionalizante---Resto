using System;
using System.Collections.Generic;

namespace PyotectoProfesionalizante___Resto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mesa> Mesas = new List<Mesa>();
            Mesas.Add(new Mesa(1, 2, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(2, 2, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(3, 2, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(4, 4, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(5, 4, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(6, 4, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(7, 2, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(8, 2, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(9, 2, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(10, 4, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(11, 4, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(12, 4, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(13, 2, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(14, 2, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(15, 2, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(16, 4, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(17, 4, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(18, 4, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(19, 2, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(20, 2, EstadoMesa.Disponible));
            Mesas.Add(new Mesa(1, 2, EstadoMesa.Disponible));

            List<Reserva> Reservas = new List<Reserva>();
            List<Comensal> Clientes = new List<Comensal>();
            Restaurante Resto = new Restaurante("PF&O", "Yatay 408", Mesas, Reservas, Clientes);
        }
    }
}
