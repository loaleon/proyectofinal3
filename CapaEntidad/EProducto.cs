using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EProducto
    {
        public int idProducto { get; set; }
        public string nombreProd { get; set; }
        public int prodMax { get; set; }
        public int prodMin { get; set; }
        public decimal precioCompra { get; set; }
        public decimal precioVenta { get; set; }
        public DateTime fechaIngreso { get; set; }
        public int idTipoProd { get; set; }
    }    
}
