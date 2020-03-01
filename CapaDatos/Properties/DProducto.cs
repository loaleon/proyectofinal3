using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos.Properties
{
   public class DProducto
    {
        public void InsertarProducto(EProducto obj)
        {

            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspInsertProducto", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombreProd", obj.idProducto);
            cmd.Parameters.AddWithValue("@prodMax", obj.prodMax);
            cmd.Parameters.AddWithValue("@prodMin", obj.prodMin);
            cmd.Parameters.AddWithValue("@precioCompra", obj.precioVenta);
            cmd.Parameters.AddWithValue("@precioVenta", obj.precioVenta);
            cmd.Parameters.AddWithValue("@fechaIngreso", obj.fechaIngreso);
            cmd.Parameters.AddWithValue("@idTipoProd", obj.idTipoProd);


            SqlCon.Open();

            cmd.ExecuteNonQuery();

            SqlCon.Close();
        }
    }
}
