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
            SqlCommand cmd = new SqlCommand("uspSelectCliente", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlCon.Open();
            cmd.Parameters.AddWithValue("@buscar", buscar);
            Mostrar = cmd.ExecuteReader();

            List<ECliente> Listar = new List<ECliente>();

            while (Mostrar.Read())
            {
                Listar.Add(new ECliente
                {

                    idCliente = Mostrar.GetInt32(0),
                    nombre = Mostrar.GetString(1),
                    apellido = Mostrar.GetString(2),
                    tipoDocumento = Mostrar.GetString(3),
                    documento = Mostrar.GetString(4),
                    direccion = Mostrar.GetString(5),
                    telefono = Mostrar.GetString(6),
                    correo = Mostrar.GetString(7),
                    sexo = Mostrar.GetString(8),
                    fechaIngreso = Mostrar.GetDateTime(9)
                });
            }
            SqlCon.Close();
            Mostrar.Close();

            return Listar;
        }


    }
}
