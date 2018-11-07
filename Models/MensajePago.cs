using System.ComponentModel.DataAnnotations;

namespace Proyecto_Fia.Models{

    public class MensajePago
    {

        public int Id { get; set; }    

        [MaxLength(15)]
        [Required]
        public string Nombre { get; set; }

        [MaxLength(20)]
        [Required]
        public string Apellido { get; set; }

        [EmailAddress]
        [Required]
        public string Correo {get; set;}

        [MaxLength(30)]
        [Required]
        public string Direccion { get; set; }

        [MaxLength(30)]
        [Required]
        public string DireccionTwo { get; set; }

        [MaxLength(20)]
        [Required]
        public string Distrito { get; set; }

        [MaxLength(30)]
        [Required]
        public string  Calle { get; set; }

        [MaxLength(10)]
        [Required]
        public string CodigoPostal { get; set; }

        
        [Required]
        public string TipoTarjeta { get; set; }

        [MaxLength(20)]
        [Required]
        public string NombreTitular { get; set; }

        [MaxLength(20)]
        [Required]
        public string NumeroTarjeta { get; set; }

        
        [MaxLength(8)]
        [Required]
        public string CodigoExpiracion { get; set; }

        [MaxLength(5)]
        [Required]
        public string CodigoCvv { get; set; }

        
        [Required]
        public string TipoServicio { get; set; }





        



























        
    }








}