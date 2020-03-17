using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;



namespace CapaDatos
{
    public class DDepartamento
    {
        public void InsertarDepartamento(EDepartamento obj)
        {

            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspInsertDeparamento", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre", obj.nombre.ToUpper());


            SqlCon.Open();

            cmd.ExecuteNonQuery();

            SqlCon.Close();
        }
        public List<EDepartamento> ListarDepartamento(string buscar)
        {
            SqlDataReader Mostrar;
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspSelectDepartamento", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlCon.Open();
            cmd.Parameters.AddWithValue("@buscar", buscar);
            Mostrar = cmd.ExecuteReader();

            List<EDepartamento> Listar = new List<EDepartamento>();

            while (Mostrar.Read())
            {
                Listar.Add(new EDepartamento
                {

                    idDepartamento = Mostrar.GetInt32(0),
                    nombre = Mostrar.GetString(1),

                });
            }
            SqlCon.Close();
            Mostrar.Close();

            return Listar;
        }
        public void ActualizarDepartamento(EDepartamento obj)
        {

            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspUpdateDepartamento", SqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", obj.nombre.ToUpper());
            SqlCon.Open();

            cmd.ExecuteNonQuery();

            SqlCon.Close();
        }
        public void ElimiarDepartamento(EDepartamento obj)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspDeleteDepartamento", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idDepartamento", obj.idDepartamento);

            SqlCon.Open();
            cmd.ExecuteNonQuery();
            SqlCon.Close();

        }
    }
}
