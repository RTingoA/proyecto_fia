﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_Fia.Context;

namespace Proyecto_Fia.Migrations
{
    [DbContext(typeof(CarWashContext))]
    partial class CarWashContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proyecto_Fia.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Proyecto_Fia.Models.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired();

                    b.Property<string>("Nombres")
                        .IsRequired();

                    b.Property<int?>("SucursalId");

                    b.HasKey("Id");

                    b.HasIndex("SucursalId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Proyecto_Fia.Models.Mensa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(9);

                    b.Property<string>("Correo")
                        .IsRequired();

                    b.Property<string>("Direccion")
                        .IsRequired();

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Texto");

                    b.HasKey("Id");

                    b.ToTable("Mensas");
                });

            modelBuilder.Entity("Proyecto_Fia.Models.MensajePago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Calle");

                    b.Property<string>("CodigoCvv")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("CodigoExpiracion")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<string>("CodigoPostal")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Correo")
                        .IsRequired();

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("DireccionTwo")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Distrito")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("NombreTitular")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("NumeroTarjeta")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("TipoServicio")
                        .IsRequired();

                    b.Property<string>("TipoTarjeta")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("MensajePagos");
                });

            modelBuilder.Entity("Proyecto_Fia.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Foto");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Proyecto_Fia.Models.ProductoCategoria", b =>
                {
                    b.Property<int>("ProductoId");

                    b.Property<int>("CategoriaId");

                    b.HasKey("ProductoId", "CategoriaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("ProductoCategoria");
                });

            modelBuilder.Entity("Proyecto_Fia.Models.Sucursal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Sucursales");

                    b.HasData(
                        new { Id = 1, Direccion = "Av Javier Prado 5200", Nombre = "Oficina principal" },
                        new { Id = 2, Direccion = "Av Angamos 1050", Nombre = "Sucursal 1" },
                        new { Id = 3, Direccion = "Av Las Palmeras 1020", Nombre = "Sucursal 2" }
                    );
                });

            modelBuilder.Entity("Proyecto_Fia.Models.TipoTarjeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("TipoTarjetas");

                    b.HasData(
                        new { Id = 1, Nombre = "Visa" },
                        new { Id = 2, Nombre = "Mastercard" },
                        new { Id = 3, Nombre = "Paypal" }
                    );
                });

            modelBuilder.Entity("Proyecto_Fia.Models.Empleado", b =>
                {
                    b.HasOne("Proyecto_Fia.Models.Sucursal", "Sucursal")
                        .WithMany("Empleados")
                        .HasForeignKey("SucursalId");
                });

            modelBuilder.Entity("Proyecto_Fia.Models.ProductoCategoria", b =>
                {
                    b.HasOne("Proyecto_Fia.Models.Categoria", "Categoria")
                        .WithMany("ProductosCategorias")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Proyecto_Fia.Models.Producto", "Producto")
                        .WithMany("ProductosCategorias")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
