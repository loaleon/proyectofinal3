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
   public class DTipoProducto
    {
        public void InsertarTipoProducto(ETipoProducto obj)
        {


            //string agregar = "";
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspInserttipoProd", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre", obj.nombre);
            cmd.Parameters.AddWithValue("@descripcion", obj.descripcion);

            SqlCon.Open();

            cmd.ExecuteNonQuery();

            SqlCon.Close();


        }
        public List<ETipoProducto> ListarTipoProducto(string buscar)
        {
            SqlDataReader Mostrar;
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspSelecttipoProd", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlCon.Open();
            cmd.Parameters.AddWithValue("@buscar", buscar);
            Mostrar = cmd.ExecuteReader();

            List<ETipoProducto> Listar = new List<ETipoProducto>();

            while (Mostrar.Read())
            {
                Listar.Add(new ETipoProducto
                {
                    idTipoProd = Mostrar.GetInt32(0),
                    nombre = Mostrar.GetString(1),
                    descripcion = Mostrar.GetString(2),   

                });

            }

            SqlCon.Close();
            Mostrar.Close();

            return Listar;
        }
        public void ActualizarTipoProducto(ETipoProducto obj)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspUpdatetipoProd", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idTipoProd", obj.idTipoProd);
            cmd.Parameters.AddWithValue("@nombre", obj.nombre);
            cmd.Parameters.AddWithValue("@descripcion", obj.descripcion);
            
            SqlCon.Open();
            cmd.ExecuteNonQuery();

            SqlCon.Close();

        }
        public void ElimiarTipoProducto(ETipoProducto obj)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspDeletetipoProd", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idTipoProd", obj.idTipoProd);

            SqlCon.Open();
            cmd.ExecuteNonQuery();
            SqlCon.Close();

        }

    }
}
