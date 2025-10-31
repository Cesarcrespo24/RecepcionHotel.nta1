using System;

namespace HotelRecepcion.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public string? NombreHuesped { get; set; }
        public string? NumeroHabitacion { get; set; }
        public DateTime FechaReserva { get; set; }
        public string? Estado { get; set; }
    }
}
