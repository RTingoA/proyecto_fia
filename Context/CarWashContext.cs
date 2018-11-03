using Microsoft.EntityFrameworkCore;
using Proyecto_Fia.Models;

namespace Proyecto_Fia.Context
{
    public class CarWashContext : DbContext
    {
        public CarWashContext(DbContextOptions<CarWashContext> dco) : base (dco) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductoCategoria>().HasKey(t => new { t.ProductoId, t.CategoriaId });
            modelBuilder.Entity<ProductoCategoria>().HasOne(pc => pc.Producto).WithMany(p => p.ProductosCategorias).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ProductoCategoria>().HasOne(pc => pc.Categoria).WithMany(p => p.ProductosCategorias).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Sucursal>().HasData(
                new Sucursal {
                    Id = 1,
                    Nombre = "Oficina principal",
                    Direccion = "Av Javier Prado 5200"
                },
                new Sucursal {
                    Id = 2,
                    Nombre = "Sucursal Surquillork",
                    Direccion = "Av Angamos 1050"
                },
                new Sucursal {
                    Id = 3,
                    Nombre = "Sucursal San Juan de Luriguashington",
                    Direccion = "Av Las Palmeras 1020"
                }
            );
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
    }
}