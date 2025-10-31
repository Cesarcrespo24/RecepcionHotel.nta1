using HotelRecepcion.Data;
using HotelRecepcion.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelRecepcion.Controllers
{
    public class HuespedesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HuespedesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Huespedes/Crear
        public IActionResult Crear()
        {
            return View();
        }

        // POST: /Huespedes/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Huesped huesped)
        {
            if (ModelState.IsValid)
            {
                _context.Huespedes.Add(huesped);
                _context.SaveChanges();
                TempData["Mensaje"] = $"Huésped {huesped.Nombre} {huesped.Apellido} registrado correctamente.";
                return RedirectToAction("Index", "Dashboard");
            }

            return View(huesped);
        }
    }
}

