using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;


namespace CapaNegocio
{
   public class NProducto
    {
        DProducto Datos = new DProducto();
        public void InsertandoProductoBD(EProducto obj)
        {
            Datos.InsertarProducto(obj);
        }

        public List<EProducto> BuscarProductoBD(string buscar)
        {
            return Datos.ListarProducto(buscar);
        }

        public DataTable Seleccionar()
        {

            return Datos.Listar();
            
        }

        public DataTable SeleccionarProveedorBox()
        {

            return Datos.ListarProveedorBox();

        }

        /*public List<EProducto> CargarListaComboBox(string buscar)
        {
            return Datos.ListarProducto(buscar);

            
        }*/


        public void ActualizarProductoBD(EProducto obj)
        {
            Datos.ActualizarProducto(obj);
        }

        public void EliminandoProductoBD(EProducto obj)
        {
            Datos.ElimiarProducto(obj);
        }
    }
}
