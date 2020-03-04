using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NTipoProducto
    {
        DTipoProducto Datos = new DTipoProducto();
        public void InsertandoTipoProductoBD(ETipoProducto obj)
        {
            Datos.InsertarTipoProducto(obj);
        }

        public List<ETipoProducto> BuscarTipoProductoBD(string buscar)
        {
            return Datos.ListarTipoProducto(buscar);
        }

        public void ActualizarTipoProductoBD(ETipoProducto obj)
        {
            Datos.ActualizarTipoProducto(obj);
        }

        public void EliminandoTipoProductoBD(ETipoProducto obj)
        {
            Datos.ElimiarTipoProducto(obj);
        }
    }
}
