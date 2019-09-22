using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindApiDemoSwagger.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion  { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }
    }
}
