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
                cmd.Parameters.AddWithValue("@correo", obj.telefono);
                cmd.Parameters.AddWithValue("@idDepartamento", obj.idDepartamento);
                cmd.Parameters.AddWithValue("@fechaIngreso", obj.fechaIngreso);
                cmd.Parameters.AddWithValue("@fechaNacimiento", obj.fechaNacimiento);

                SqlCon.Open();

                cmd.ExecuteNonQuery();
                /*
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = obj.apellido;
                cmd.Parameters.Add("@tipoDocumento", SqlDbType.VarChar).Value = obj.tipoDocumento;
                cmd.Parameters.Add("@Documento", SqlDbType.VarChar).Value = obj.documento;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = obj.direccion;
                cmd.Parameters.Add("@sexo", SqlDbType.VarChar).Value = obj.sexo;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = obj.telefono;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = obj.correo;
                cmd.Parameters.Add("@idDepartamento", SqlDbType.Int).Value = obj.idDepartamento;
                cmd.Parameters.Add("@fechaIngreso", SqlDbType.Date).Value = obj.fechaIngreso;
                cmd.Parameters.Add("@fechaNacimiento", SqlDbType.Date).Value = obj.fechaNacimiento;
                SqlCon.Open();
            agregar = Convert.ToString(cmd.ExecuteNonQuery());

            SqlCon.Close();

            return agregar;*/

        }
        
        
    }
}
