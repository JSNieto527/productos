using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productos.Models
{
    public class MockCategoriasRepositorio: ICategoriasRepositorio
        {
            public IEnumerable<CategoriaP> CategoriasProductos
            {
                get
                {
                    return new List<CategoriaP>
                    {
                        new CategoriaP {CodCategoria = 1, Nomcategoria = "Accesorios", Descripcion = "Permitete decorar tu maquina con stickers"},
                        new CategoriaP {CodCategoria = 2, Nomcategoria = "Repuestos", Descripcion = "Repuestos para el mantenimiento de una computadora" },
                        new CategoriaP {CodCategoria = 3, Nomcategoria = "Complementos", Descripcion = "Venta de teclados y muchas mas cosas para tu computadora"},
                    };
                }
            }
        }
}
