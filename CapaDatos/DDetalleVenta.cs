using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;



namespace CapaDatos
{
   public class DDetalleVenta
    {
     public void InsertarDetalleVenta(EDetalleVenta obj)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspInsertDetalleVenta", SqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idProducto", obj.idProducto);
            cmd.Parameters.AddWithValue("@idVenta", obj.idVenta);
            cmd.Parameters.AddWithValue("@cantidad", obj.cantidad);
            cmd.Parameters.AddWithValue("@precio", obj.precio);

            SqlCon.Open();

            cmd.ExecuteNonQuery();

            SqlCon.Close();

        }
        public List<EDetalleVenta> ListarDetalleVenta(string buscar)
        {
          SqlDataReader Mostrar;
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspSelectDetalleVenta", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlCon.Open();
           // cmd.Parameters.AddWithValue("@buscar", buscar);
             Mostrar = cmd.ExecuteReader();

            List<EDetalleVenta> Listar = new List<EDetalleVenta>();

            while (Mostrar.Read())
            {
                Listar.Add(new EDetalleVenta
                {

                    idDetalleVenta = Mostrar.GetInt32(0),
                    idProducto = Mostrar.GetInt32(1),
                    idVenta = Mostrar.GetInt32(2),
                    cantidad = Mostrar.GetDecimal(3),
                    precio = Mostrar.GetDecimal(4)
                   
                });
            }
            SqlCon.Close();
            Mostrar.Close();

            return Listar;
        }

        ///Estamos trabajando con la capa de datos
    }
}
