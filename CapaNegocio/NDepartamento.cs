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
    public class NDepartamento
    {
        DDepartamento Datos = new DDepartamento();
        public void InsertandoDepartamentoBD(EDepartamento obj)
        {
            Datos.InsertarDepartamento(obj);
        }

        public List<EDepartamento> BuscarDepartamentoBD(string buscar)
        {
            return Datos.ListarDepartamento(buscar);
        }


        public void ActualizarDepartamentoBD(EDepartamento obj)
        {
            Datos.ActualizarDepartamento(obj);
        }

        public void EliminandoDepartamentoBD(EDepartamento obj)
        {
            Datos.ElimiarDepartamento(obj);
        }
    }
}

