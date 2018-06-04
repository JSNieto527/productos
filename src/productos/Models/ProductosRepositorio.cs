using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productos.Models
{
    public class ProductosRepositorio : IProductosRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public ProductosRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Productos> Productos => _appDbContext.Productos;
    }
}
