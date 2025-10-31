using System;
using System.ComponentModel.DataAnnotations;

namespace HotelRecepcion.Models
{
    public class Huesped
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(50)]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [StringLength(50)]
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "Debe ingresar un documento de identidad.")]
        [StringLength(30)]
        public string? Documento { get; set; }

        [Phone(ErrorMessage = "Ingrese un número de teléfono válido.")]
        public string? Telefono { get; set; }

        [EmailAddress(ErrorMessage = "Ingrese un correo válido.")]
        public string? Email { get; set; }

        public string?  Nacionalidad { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Ingreso")]
        public DateTime FechaIngreso { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Salida")]
        public DateTime FechaSalida { get; set; }

        [StringLength(200)]
        public string? Observaciones { get; set; }
    }
}
