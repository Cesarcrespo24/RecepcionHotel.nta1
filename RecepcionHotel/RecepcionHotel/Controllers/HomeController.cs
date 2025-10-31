using Microsoft.AspNetCore.Mvc;

namespace HotelRecepcion.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Datos de ejemplo (luego vendr�n desde SQL)
            ViewBag.NombreHotel = "Hotel Vista Mar";
            ViewBag.TotalHuespedes = 128;
            ViewBag.HabitacionesDisponibles = 14;
            ViewBag.ReservasHoy = 22;
            ViewBag.EmpleadosTurno = 6;

            return View();
        }
    }
}
