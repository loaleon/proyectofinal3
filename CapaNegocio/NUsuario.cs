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
   public class NUsuario
    {
        DUsuario Datos = new DUsuario();
        public void InsertandoUsuarioBD(EUsuario obj)
        {
            Datos.InsertarUsuario(obj);
        }

        public List<EUsuario> BuscarUsuarioBD(string buscar)
        {
            return Datos.ListarUsuario (buscar);
        }

        public static DataTable Login(string usuario, string contrasena)
        {
            DUsuario Datos = new DUsuario();
            return Datos.ListarUsuarioLogin(usuario, contrasena);
        }

        public void ActualizarUsuarioBD(EUsuario obj)
        {
            Datos.ActualizarUsuario(obj);
        }

        public void EliminandoUsuarioBD(EUsuario obj)
        {
            Datos.ElimiarUsuario(obj);
        }

    }
}
