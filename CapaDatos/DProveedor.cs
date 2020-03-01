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
   public class DProveedor
    {
        public void InsertarProveedores(EProveedor obj)
        {


            //string agregar = "";
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspInsertProveedor", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre", obj.nombre);
            cmd.Parameters.AddWithValue("@razonSocial", obj.razonSocial);
            cmd.Parameters.AddWithValue("@tipoDocumento", obj.tipoDocumento);
            cmd.Parameters.AddWithValue("@documento", obj.documento);
            cmd.Parameters.AddWithValue("@direccion", obj.direccion);
            cmd.Parameters.AddWithValue("@telefono", obj.telefono);
            cmd.Parameters.AddWithValue("@correo", obj.correo);
            cmd.Parameters.AddWithValue("@fecha", obj.fecha);
           

            SqlCon.Open();

            cmd.ExecuteNonQuery();

            SqlCon.Close();


        }
        public List<EProveedor> ListarProveedor(string buscar)
        {
            SqlDataReader Mostrar;
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspSelectProveedor", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlCon.Open();
            cmd.Parameters.AddWithValue("@buscar", buscar);
            Mostrar = cmd.ExecuteReader();

            List<EProveedor> Listar = new List<EProveedor>();

            while (Mostrar.Read())
            {
                Listar.Add(new EProveedor
                {
                    idProveedor = Mostrar.GetInt32(0),
                    nombre = Mostrar.GetString(1),
                    razonSocial = Mostrar.GetString(2),
                    direccion = Mostrar.GetString(3),
                    tipoDocumento = Mostrar.GetString(4),
                    documento = Mostrar.GetString(5),
                    telefono = Mostrar.GetString(6),
                    correo = Mostrar.GetString(7),
                    fecha = Mostrar.GetDateTime(8),
                    
                });

            }

            SqlCon.Close();
            Mostrar.Close();

            return Listar;
        }
        public void ActualizarProveedor(EProveedor obj)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspUpdateProveedor", SqlCon);
        
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idProveedor", obj.idProveedor);
            cmd.Parameters.AddWithValue("@nombre", obj.nombre);
            cmd.Parameters.AddWithValue("@razonSocial", obj.razonSocial);
            cmd.Parameters.AddWithValue("@direccion", obj.direccion);
            cmd.Parameters.AddWithValue("@tipoDocumento", obj.tipoDocumento);
            cmd.Parameters.AddWithValue("@documento", obj.documento);
            cmd.Parameters.AddWithValue("@telefono", obj.telefono);
            cmd.Parameters.AddWithValue("@correo", obj.correo);
            cmd.Parameters.AddWithValue("@fecha", obj.fecha);
            SqlCon.Open();
            cmd.ExecuteNonQuery();

            SqlCon.Close();

        }
        public void ElimiarProveedor(EProveedor obj)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspDeleteProveedor", SqlCon);
                                            
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idProveedor", obj.idProveedor);

            SqlCon.Open();
            cmd.ExecuteNonQuery();
            SqlCon.Close();

        }


    }
}
