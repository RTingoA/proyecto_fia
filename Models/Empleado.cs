using System.ComponentModel.DataAnnotations;

namespace Proyecto_Fia.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        public Sucursal Sucursal { get; set; }
        public int? SucursalId { get; set; }
    }
}