using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace productos.Models
{
    public class CategoriaP
    {
        [Key]
        public int CodCategoria { get; set; }
        public string Nomcategoria { get; set; }
        public string Descripcion { get; set; }
        public List<CategoriaP> Categorias { get; set; }
    }
}
