using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace proyectofinalp3
{
    public partial class frmBuscarCliente : Form
    {
        ECliente objEntidad = new ECliente();
        NCliente objNegocio = new NCliente();
        public void MostrarBuscarBD(string buscar)
        {

            tablaCliente.DataSource = objNegocio.BuscarClienteBD(buscar);

        }
        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            MostrarBuscarBD("");
        }

        private void tablaCliente_DoubleClick(object sender, EventArgs e)
        {

            Variables.idCliente = Convert.ToInt32(tablaCliente.CurrentRow.Cells["idCliente"].Value);
            Variables.nombre = Convert.ToString(tablaCliente.CurrentRow.Cells["nombre"].Value);
            Variables.apellido = Convert.ToString(tablaCliente.CurrentRow.Cells["apellido"].Value);

            this.Close();
            
        }
        
    }
}
