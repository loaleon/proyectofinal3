using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EProveedor
    {
        public int idProveedor { get; set; }
        public string nombre { get; set; }
        public string razonSocial { get; set; }
        public string direccion { get; set; }
        public string tipoDocumento { get; set; }
        public string documento { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public DateTime fecha { get; set; }
      
    }
}
