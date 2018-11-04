using System.ComponentModel.DataAnnotations;

namespace Proyecto_Fia.Models{


    public class Mensa{

        public int Id{get;set;}

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [MaxLength(8)]
        [Required]
        public string Dni { get; set; }

         [EmailAddress]
        [Required]
        public string Correo{get;set;}

        [MaxLength(9)]
        [Required]
        public string Celular { get; set; }

         [Required]
        public string Direccion { get; set; }


        public string Texto { get; set; }    

        

        
                    






    }

}