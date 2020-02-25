using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "UAPA";
            this.Servidor = "localhost";
            this.Usuario = "sa";
            this.Clave = "lisander05";
            this.Seguridad = true;
        }
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server =" + this.Servidor + "; Database =" + this.Base + "; ";
                if (this.Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";

                }

                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User" + this.Usuario + "; password" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;

            }
            return Cadena;

        }
        public static Conexion CrearInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }

    }
}
