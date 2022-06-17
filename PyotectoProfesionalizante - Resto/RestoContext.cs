using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PyotectoProfesionalizante___Resto
{
   public class RestoContext : DbContext
    {
        public DbSet<Restaurante> Resto { get; set; }
        public DbSet<Comensal> Clientes { get; set; }
        public DbSet<Reserva> RegistroReservas { get; set; }
        public DbSet<Mesa> Mesas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        { 
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-V5NCH6A;Database=RestauranteDB;Trusted_Connection=True;"); 
        }
    }
}

