using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace productos.Models
{
    public class Productos
    {
        [Key]
        public int codProductos { get; set; }
        public string nomProductos { get; set; }
        public string desProductos { get; set; }
        public decimal PrecProductos { get; set; }
        public virtual CategoriaP CateProductos { get; set; }
    }
}
