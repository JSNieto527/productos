using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productos.Models
{
    public interface ICategoriasRepositorio
    {
        IEnumerable<CategoriaP> CategoriasProductos { get; }
    }

}
