using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using productos.Models;
using productos.ViewsModels;


namespace productos.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly IProductosRepositorio _productosDatos;
        private readonly ICategoriasRepositorio _categoriasDatos;

        public CategoriasController(IProductosRepositorio productosDatos,
            ICategoriasRepositorio categoriasDatos)
        {
            _productosDatos = productosDatos;
            _categoriasDatos = categoriasDatos;
        }

        public ViewResult ListaCategorias()
        {
            ListaCategoriasViewsModels listacategorias = new ListaCategoriasViewsModels();
            listacategorias.Categorias = _categoriasDatos.CategoriasProductos;
            listacategorias.DatosCategorias = "Listado Categorias";

            return View(listacategorias);
        }
    }
}
