using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using productos.Models;

namespace productos.ViewsModels
{
    public class ListaProductosViewsModels
    {
        public IEnumerable<Productos> Productos { get; set; }

        public string DatosProductos { get; set; }
    }
}
