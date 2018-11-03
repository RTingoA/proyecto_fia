using System.Collections.Generic;

namespace Proyecto_Fia.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public List<ProductoCategoria> ProductosCategorias { get; set; }

        public Producto() {
            ProductosCategorias = new List<ProductoCategoria>();
        }
    }
}