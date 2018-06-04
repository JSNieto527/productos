using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace productos.Models
{
    public class CategoriaRepositorio : ICategoriasRepositorio
    {
        private readonly AppDbContext _appDbContext;

        //metodo constructor 
        public CategoriaRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        public IEnumerable<CategoriaP> CategoriasProductos => _appDbContext.CategoriasProductos;
    }
}
