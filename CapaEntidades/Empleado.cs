using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    class Empleado
    {
        private string nombre;
        private string apellido;
        private string tipoDocumento;
        private string documento;
        private string direccion;
        private string sexo;
        private string telefono;
        private string correo;
        private int idDepartamento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }
    }
}
