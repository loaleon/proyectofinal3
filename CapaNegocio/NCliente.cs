using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
   public class NCliente
    {
        DCliente Datos = new DCliente();
        public void InsertandoClienteBD(ECliente obj)
        {
            Datos.InsertarCliente(obj);
        }

        public List<ECliente> BuscarClienteBD(string buscar)
        {
            return Datos.ListarCliente(buscar);
        }

        public void ActualizarClienteBD(ECliente obj)
        {
            Datos.ActualizarCliente(obj);
        }

        public void EliminandoClienteBD(ECliente obj)
        {
            Datos.ElimiarCliente(obj);
        }

        


    }
}
