using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productos.Models
{
    public class MockProductosRepositorio: IProductosRepositorio
    {
        private readonly ICategoriasRepositorio _categoriasRepositorio = new MockCategoriasRepositorio();

        public IEnumerable<Productos> Productos
        {
            get
            {
                return new List<Productos>
                {
                    new Productos {codProductos = 1, nomProductos = "Monitor", desProductos = "Pantalla LCD de 15 plg", PrecProductos = 60},
                    new Productos {codProductos = 2, nomProductos = "Disco duro", desProductos = "Capacidad de 520 gb", PrecProductos = 50},
                    new Productos {codProductos = 3, nomProductos = "Stickers decorativos", desProductos = "Decoracion para computador", PrecProductos = 030 },
                };
            }
        }
    }
}
