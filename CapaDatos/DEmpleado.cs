using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DEmpleado
    {
        public DataTable ListarEmpleadoBox()
        {

            SqlConnection SqlCon = Conexion.CrearInstancia().CrearConexion();


            SqlCommand cmd = new SqlCommand("uspSelectDepartamento", SqlCon);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlCon.Close();

            return dt;

        }
        public void InsertarEmpleado(Empleado obj)
        {


            //string agregar = "";
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("uspInsertarEmpleado", SqlCon);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", obj.nombre);
                cmd.Parameters.AddWithValue("@apellido", obj.apellido);
                cmd.Parameters.AddWithValue("@tipoDocumento", obj.tipoDocumento);
                cmd.Parameters.AddWithValue("@documento", obj.documento);
                cmd.Parameters.AddWithValue("@direccion", obj.direccion);
                cmd.Parameters.AddWithValue("@sexo", obj.sexo);
                cmd.Parameters.AddWithValue("@telefono", obj.telefono);
                cmd.Parameters.AddWithValue("@correo", obj.correo);
                cmd.Parameters.AddWithValue("@idDepartamento", obj.idDepartamento);
                cmd.Parameters.AddWithValue("@fechaIngreso", obj.fechaIngreso);
                cmd.Parameters.AddWithValue("@fechaNacimiento", obj.fechaNacimiento);
               
                SqlCon.Open();

                cmd.ExecuteNonQuery();

                 SqlCon.Close();
            

        }
        
        public List<Empleado>ListarEmpleado(string buscar)
        {
            SqlDataReader Mostrar;
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspSelectEmpleado", SqlCon);
            
            cmd.CommandType = CommandType.StoredProcedure;

            SqlCon.Open();
            cmd.Parameters.AddWithValue("@buscar", buscar);
            Mostrar = cmd.ExecuteReader();

            List<Empleado> Listar = new List<Empleado>();

            while (Mostrar.Read())
            {
                Listar.Add(new Empleado
                {
                   idEmpleado = Mostrar.GetInt32(0),
                   nombre = Mostrar.GetString(1),
                   apellido = Mostrar.GetString(2),
                   tipoDocumento = Mostrar.GetString(3),
                   documento = Mostrar.GetString(4),
                   direccion = Mostrar.GetString(5),
                   sexo = Mostrar.GetString(6),
                   telefono = Mostrar.GetString(7),
                   correo = Mostrar.GetString(8),
                   idDepartamento = Mostrar.GetInt32(9),
                   fechaIngreso = Mostrar.GetDateTime(10),
                   fechaNacimiento = Mostrar.GetDateTime(11)

                   

                   
                });
                
            }

            SqlCon.Close();
            Mostrar.Close();

            return Listar;
        }

        public void ActualizarEmpleado(Empleado obj)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspUdateEmpleado", SqlCon);
           
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idEmpleado", obj.idEmpleado);
            cmd.Parameters.AddWithValue("@nombre", obj.nombre);
            cmd.Parameters.AddWithValue("@apellido", obj.apellido);
            cmd.Parameters.AddWithValue("@tipoDocumento", obj.tipoDocumento);
            cmd.Parameters.AddWithValue("@documento", obj.documento);
            cmd.Parameters.AddWithValue("@direccion", obj.direccion);
            cmd.Parameters.AddWithValue("@sexo", obj.sexo);
            cmd.Parameters.AddWithValue("@telefono", obj.telefono);
            cmd.Parameters.AddWithValue("@correo", obj.correo);
            cmd.Parameters.AddWithValue("@idDepartamento", obj.idDepartamento);
            cmd.Parameters.AddWithValue("@fechaIngreso", obj.fechaIngreso);
            cmd.Parameters.AddWithValue("@fechaNacimiento", obj.fechaNacimiento);

            SqlCon.Open();
            cmd.ExecuteNonQuery();

            SqlCon.Close();

        }
            
        public void ElimiarEmpleado(Empleado obj)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspDeleteEmpleado", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idEmpleado", obj.idEmpleado);

            SqlCon.Open();
            cmd.ExecuteNonQuery();
            SqlCon.Close();
            
        }

     
        
    } 
}
