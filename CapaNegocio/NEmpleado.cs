using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class NEmpleado
    {
        DEmpleado Datos = new DEmpleado();
        public void InsertandoEmpleadoBD(Empleado obj)
        {
            Datos.InsertarEmpleado(obj);
        }

        public List<Empleado>BuscarEmpleadoBD(string buscar)
        {
            return Datos.ListarEmpleado(buscar);
        }
        public DataTable SeleccionarDepartamento()
        {

            return Datos.ListarEmpleadoBox();

        }
        public void ActualizarEmpleadoBD(Empleado obj)
        {
            Datos.ActualizarEmpleado(obj);
        }

        public void EliminandoEmpleadoBD(Empleado obj)
        {
            Datos.ElimiarEmpleado(obj);
        }       
    } 
}