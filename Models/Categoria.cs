using System.Collections.Generic;

namespace Proyecto_Fia.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<ProductoCategoria> ProductosCategorias { get; set; }

        public Categoria() {
            ProductosCategorias = new List<ProductoCategoria>();
        }
    }
}