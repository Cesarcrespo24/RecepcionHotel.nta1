using HotelRecepcion.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HotelRecepcion.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            // Leer datos desde la base de datos
            var totalHabitaciones = _context.Habitaciones.Count();
            var ocupadas = _context.Habitaciones.Count(h => !h.Disponible);
            var disponibles = _context.Habitaciones.Count(h => h.Disponible);
            var reservasPendientes = _context.Reservas.Count(r => r.Estado == "Pendiente");

            // Calcular porcentaje de ocupación
            int porcentaje = totalHabitaciones > 0
                ? (int)((double)ocupadas / totalHabitaciones * 100)
                : 0;

            // Pasar datos a la vista
            ViewBag.HabitacionesOcupadas = ocupadas;
            ViewBag.HabitacionesDisponibles = disponibles;
            ViewBag.ReservasPendientes = reservasPendientes;
            ViewBag.PorcentajeOcupacion = porcentaje;

            // Últimos huéspedes registrados
            ViewBag.UltimosHuespedes = _context.Huespedes
                .OrderByDescending(h => h.Id)
                .Take(5)
                .ToList();

            // Últimas reservas
            ViewBag.UltimasReservas = _context.Reservas
                .OrderByDescending(r => r.FechaReserva)
                .Take(5)
                .ToList();

            return View();
        }
    }
}

