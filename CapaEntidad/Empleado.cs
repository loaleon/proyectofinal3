using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Empleado
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipoDocumento { get; set; }
        public string documento { get; set;}
        public string direccion { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public int idDepartamento { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
}
