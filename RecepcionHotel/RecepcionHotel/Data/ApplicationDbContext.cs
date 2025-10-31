using Microsoft.EntityFrameworkCore;
using HotelRecepcion.Models;

namespace HotelRecepcion.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Tablas que se crearán en la base de datos
        public DbSet<Huesped> Huespedes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
    }
}
