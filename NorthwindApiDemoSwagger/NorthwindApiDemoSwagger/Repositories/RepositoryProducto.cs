using NorthwindApiDemoSwagger.Models;
using System;
using System.Collections.Generic;

namespace NorthwindApiDemoSwagger.Repositories
{
    public class RepositoryProducto : IRepositoryProducto
    {
        public List<Producto> ObtenerListadoProductos()
        {
            var lstProducto = new List<Producto>();
            lstProducto.Add(new Producto() { Id = 1, Descripcion = "Arroz Faraon", Precio = 5, Stock = 5 });
            lstProducto.Add(new Producto() { Id = 2, Descripcion = "Atun Campomar", Precio = 3, Stock = 8 });
            return lstProducto;
        }
    }
}
