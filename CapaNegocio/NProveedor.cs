using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NProveedor
    {
        DProveedor Datos = new DProveedor();
        public void InsertandoProveedorBD(EProveedor obj)
        {
            Datos.InsertarProveedores(obj);
        }

        public List<EProveedor> BuscarProveedorBD(string buscar)
        {
            return Datos.ListarProveedor(buscar);
        }

        public void ActualizarProveedorBD(EProveedor obj)
        {
            Datos.ActualizarProveedor(obj);
        }

        public void EliminandoProveedorBD(EProveedor obj)
        {
            Datos.ElimiarProveedor(obj);
        }


    }
}
