using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using productos.Models;


namespace productos.ViewsModels
{
    public class ListaCategoriasViewsModels
    {
        public IEnumerable<CategoriaP> Categorias { get; set; }

        public string DatosCategorias { get; set; }
    }
}
