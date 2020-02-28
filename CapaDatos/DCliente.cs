using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DCliente
    {
        public void InsertarCliente(ECliente obj)
        {

            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspInsertCliente", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre", obj.nombre);
            cmd.Parameters.AddWithValue("@apellido", obj.apellido);
            cmd.Parameters.AddWithValue("@tipoDocumento", obj.tipoDocumento);
            cmd.Parameters.AddWithValue("@documento", obj.documento);
            cmd.Parameters.AddWithValue("@direccion", obj.direccion);
            cmd.Parameters.AddWithValue("@telefono", obj.telefono);
            cmd.Parameters.AddWithValue("@correo", obj.correo);
            cmd.Parameters.AddWithValue("@sexo", obj.sexo);
            cmd.Parameters.AddWithValue("@fechaIngreso", obj.fechaIngreso);


            SqlCon.Open();

            cmd.ExecuteNonQuery();

            SqlCon.Close();
        }

        public List<ECliente> ListarCliente(string buscar)
        {
            SqlDataReader Mostrar;
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspSelectCliente", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlCon.Open();
            cmd.Parameters.AddWithValue("@buscar", buscar);
            Mostrar = cmd.ExecuteReader();

            List<ECliente>Listar = new List<ECliente>();

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

        public void ActualizarCliente(ECliente obj)
        {

            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspUpdateCliente", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre", obj.nombre);
            cmd.Parameters.AddWithValue("@apellido", obj.apellido);
            cmd.Parameters.AddWithValue("@tipoDocumento", obj.tipoDocumento);
            cmd.Parameters.AddWithValue("@documento", obj.documento);
            cmd.Parameters.AddWithValue("@direccion", obj.direccion);
            cmd.Parameters.AddWithValue("@telefono", obj.telefono);
            cmd.Parameters.AddWithValue("@correo", obj.correo);
            cmd.Parameters.AddWithValue("@sexo", obj.sexo);
            cmd.Parameters.AddWithValue("@fechaIngreso", obj.fechaIngreso);


            SqlCon.Open();

            cmd.ExecuteNonQuery();

            SqlCon.Close();
        }
        public void ElimiarCliente(ECliente obj)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspDeleteCliente", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idEmpleado", obj.idCliente);

            SqlCon.Open();
            cmd.ExecuteNonQuery();
            SqlCon.Close();

        }

    }
}
