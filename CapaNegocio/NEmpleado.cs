using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NEmpleado
    {
        DEmpleado Datos = new DEmpleado();
        public void InsertandoEmpleadoBD(Empleado obj)
        {
            Datos.InsertarEmpleado(obj);
        }

        /*
        public static string InsertarEmpleado(string Nombre, string Apellido, 
        string tipoDocumento, string Documento, string Direccion, string Sexo,
        string Telefono, string Correo, int idDepartamento, DateTime fechaIngreso,
        DateTime fechaNacimiento)
        {
            DEmpleado Datos = new DEmpleado();
            Empleado obj = new Empleado();
            obj.nombre = Nombre;
            obj.apellido = Apellido;
            obj.tipoDocumento = tipoDocumento;
            obj.documento = Documento;
            obj.direccion = Direccion;
            obj.sexo = Sexo;
            obj.telefono = Telefono;
            obj.correo = Correo; 
            obj.idDepartamento = idDepartamento;
            obj.fechaIngreso = fechaIngreso;
            obj.fechaNacimiento = fechaNacimiento;
            
            
        }
        */
    } 
}