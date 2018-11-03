namespace Proyecto_Fia.Models
{
    public class ProductoCategoria
    {
        public Producto Producto { get; set; }
        public int ProductoId { get; set; }

        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
    }
}