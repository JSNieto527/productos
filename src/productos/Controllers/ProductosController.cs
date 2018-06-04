using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using productos.Models;
using productos.ViewsModels;

namespace productos.Controllers
{
    public class ProductosController : Controller
    {
        private readonly IProductosRepositorio _productosRepositorio;
        private readonly ICategoriasRepositorio _categoriasRepositorio;

        public ProductosController(IProductosRepositorio productosDatos,
            ICategoriasRepositorio categoriasDatos)
        {
            _productosRepositorio = productosDatos;
            _categoriasRepositorio = categoriasDatos;

        }

        public ViewResult ListaProductos()
        {

            ListaProductosViewsModels listaproductosviewsmodels = new ListaProductosViewsModels();
            listaproductosviewsmodels.Productos = _productosRepositorio.Productos;
            listaproductosviewsmodels.DatosProductos = "Listado de Productos";

            return View(listaproductosviewsmodels);
        }
    }
}
