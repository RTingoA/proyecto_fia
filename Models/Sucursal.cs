using System.Collections.Generic;

namespace Proyecto_Fia.Models
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Empleado> Empleados { get; set; }

        public Sucursal() {
            Empleados = new List<Empleado>();
        }
    }
}