using Microsoft.AspNetCore.Mvc;
using NorthwindApiDemoSwagger.Models;
using NorthwindApiDemoSwagger.Repositories;
using System.Collections.Generic;

namespace NorthwindApiDemoSwagger.Controller
{
    [Route("api/Producto")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        IRepositoryProducto repository;

        public ProductoController(IRepositoryProducto repository)
        {
            this.repository = repository;
        }

        [HttpGet("productos")]
        public IActionResult ListadoProductos()
        {
            var listado = new List<Producto>();
            listado = repository.ObtenerListadoProductos();
            return Ok(listado);
        }
    }
}