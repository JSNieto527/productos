using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using productos.Models;

namespace productos.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("productos.Models.CategoriaP", b =>
                {
                    b.Property<int>("CodCategoria")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoriaPCodCategoria");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nomcategoria");

                    b.HasKey("CodCategoria");

                    b.HasIndex("CategoriaPCodCategoria");

                    b.ToTable("CategoriasProductos");
                });

            modelBuilder.Entity("productos.Models.Productos", b =>
                {
                    b.Property<int>("codProductos")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CateProductosCodCategoria");

                    b.Property<decimal>("PrecProductos");

                    b.Property<string>("desProductos");

                    b.Property<string>("nomProductos");

                    b.HasKey("codProductos");

                    b.HasIndex("CateProductosCodCategoria");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("productos.Models.CategoriaP", b =>
                {
                    b.HasOne("productos.Models.CategoriaP")
                        .WithMany("Categorias")
                        .HasForeignKey("CategoriaPCodCategoria");
                });

            modelBuilder.Entity("productos.Models.Productos", b =>
                {
                    b.HasOne("productos.Models.CategoriaP", "CateProductos")
                        .WithMany()
                        .HasForeignKey("CateProductosCodCategoria");
                });
        }
    }
}
