using NorthwindApiDemoSwagger.Models;
using System.Collections.Generic;

namespace NorthwindApiDemoSwagger.Repositories
{
    public interface IRepositoryProducto
    {
        List<Producto> ObtenerListadoProductos();
    }
}
