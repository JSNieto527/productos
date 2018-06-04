using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace productos.Migrations
{
    public partial class product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriasProductos",
                columns: table => new
                {
                    CodCategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoriaPCodCategoria = table.Column<int>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Nomcategoria = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasProductos", x => x.CodCategoria);
                    table.ForeignKey(
                        name: "FK_CategoriasProductos_CategoriasProductos_CategoriaPCodCategoria",
                        column: x => x.CategoriaPCodCategoria,
                        principalTable: "CategoriasProductos",
                        principalColumn: "CodCategoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    codProductos = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CateProductosCodCategoria = table.Column<int>(nullable: true),
                    PrecProductos = table.Column<decimal>(nullable: false),
                    desProductos = table.Column<string>(nullable: true),
                    nomProductos = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.codProductos);
                    table.ForeignKey(
                        name: "FK_Productos_CategoriasProductos_CateProductosCodCategoria",
                        column: x => x.CateProductosCodCategoria,
                        principalTable: "CategoriasProductos",
                        principalColumn: "CodCategoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasProductos_CategoriaPCodCategoria",
                table: "CategoriasProductos",
                column: "CategoriaPCodCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CateProductosCodCategoria",
                table: "Productos",
                column: "CateProductosCodCategoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "CategoriasProductos");
        }
    }
}
