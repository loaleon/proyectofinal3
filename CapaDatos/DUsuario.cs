using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class DUsuario
    {
        public void InsertarUsuario(EUsuario obj)
        {

            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspInsertUsuario", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

       
            cmd.Parameters.AddWithValue("@usuario", obj.usuario);
            cmd.Parameters.AddWithValue("@contrasena", obj.contrasena);
            cmd.Parameters.AddWithValue("@idEmpleado", obj.idEmpleado);
            SqlCon.Open();

            cmd.ExecuteNonQuery();

            SqlCon.Close();
        }
        public List<EUsuario> ListarUsuario(string buscar)
        {
            SqlDataReader Mostrar;
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspSelectUsuario", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlCon.Open();
            cmd.Parameters.AddWithValue("@buscar", buscar);
            Mostrar = cmd.ExecuteReader();

            List<EUsuario> Listar = new List<EUsuario>();

            while (Mostrar.Read())
            {
                Listar.Add(new EUsuario
                {

                    idUsuario = Mostrar.GetInt32(0),
                    usuario = Mostrar.GetString(1),
                    contrasena = Mostrar.GetString(2),
                    idEmpleado = Mostrar.GetInt32(3)
                    
                });
            }
            SqlCon.Close();
            Mostrar.Close();

            return Listar;
        }
        public void ActualizarUsuario(EUsuario obj)
        {

            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspUpdateUsuario", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idusuario", obj.idUsuario);
            cmd.Parameters.AddWithValue("@usuario", obj.usuario);
            cmd.Parameters.AddWithValue("@contrasena", obj.contrasena);
            cmd.Parameters.AddWithValue("idEmpleado", obj.idEmpleado);
            SqlCon.Open();

            cmd.ExecuteNonQuery();

            SqlCon.Close();
        }
        public void ElimiarUsuario(EUsuario obj)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspDeleteUsuario", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idUsuario", obj.idUsuario);

            SqlCon.Open();
            cmd.ExecuteNonQuery();
            SqlCon.Close();

        }
    }
}
