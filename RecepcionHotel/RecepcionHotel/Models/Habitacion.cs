namespace HotelRecepcion.Models
{
    public class Habitacion
    {
        public int Id { get; set; }
        public string? Numero { get; set; }
        public string? Tipo { get; set; } // Ej: Simple, Doble, Suite
        public bool Disponible { get; set; }
        public decimal PrecioPorNoche { get; set; }
    }
}
