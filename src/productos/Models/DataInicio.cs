using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace productos.Models
{
    public static class DataInicio
    {

        public static void AgregarData(IApplicationBuilder ab)
        {
            AppDbContext contexto = ab.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!contexto.CategoriasProductos.Any())
            {
                //CategoriasProductosIniciales es una coleccion local
                contexto.CategoriasProductos.AddRange(categoriPiniciales.Select(c => c.Value));
            }
            if (!contexto.Productos.Any())
            {
                contexto.AddRange
                (
                    new Productos { nomProductos = "Disco duro", desProductos = "Disco duro de 500 gb", PrecProductos = 35.0M},
                    new Productos { nomProductos = "Monitor LCD", desProductos = "Monitor LCD de 20 pg", PrecProductos = 25.0M},
                    new Productos { nomProductos = "Memoria RAM", desProductos = "Memoria RAM de 4 gb para computadora de escritorio", PrecProductos = 30.0M },
                    new Productos { nomProductos = "Mouse inalambrio", desProductos = "Mouse inalambrico pequeño", PrecProductos = 16.0M },
                    new Productos { nomProductos = "Bocinas para computador", desProductos = "Bocinas para computadora de escritorio", PrecProductos = 25.0M},
                    new Productos { nomProductos = "Cooler", desProductos = "Cooler de 4 ventiladores para laptop", PrecProductos = 30.0M}
                );
            }

            contexto.SaveChanges();
        }//fin de agregarData

        //se hace referencia a la clase dominio CatProductos
        public static Dictionary<string, CategoriaP> categoriPiniciales;
        public static Dictionary<string, CategoriaP> CategoriPIniciales
        {
            get
            {
                if (categoriPiniciales == null)
                {
                    var listadoCategorias = new CategoriaP[]
                    {
                        new CategoriaP { Nomcategoria = "Monitor de computadora" },
                        new CategoriaP { Nomcategoria = "Hardware" },
                        new CategoriaP { Nomcategoria = "Complementos de computadora" },
                    };
                    categoriPiniciales = new Dictionary<string, CategoriaP>();

                    foreach (CategoriaP categProini in listadoCategorias)
                    {
                        categoriPiniciales.Add(categProini.Nomcategoria, categProini);
                    }//fin del foreach
                }
                return categoriPiniciales;
            }//fin del metodo get
        }//fin de diccionario de categorias
    }
}
