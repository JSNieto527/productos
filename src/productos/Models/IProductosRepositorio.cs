using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using productos.Controllers;
using productos.ViewsModels;

namespace productos.Models
{
    public interface IProductosRepositorio
    {
        IEnumerable<Productos> Productos { get; }

    }
}
