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
    public partial class frmClientes : Form
    {
        //private string ListaCliente;
        ECliente objEntidad = new ECliente();
        NCliente objNegocio = new NCliente();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnver_Click(object sender, EventArgs e)
        {
            frmMostrarCliente miforma = new frmMostrarCliente();
            miforma.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objEntidad.nombre = txtNombre.Text.ToUpper();
            objEntidad.apellido = txtApellido.Text.ToUpper();
            objEntidad.direccion = txtDireccion.Text.ToUpper();
            objEntidad.sexo = txtSexo.Text.ToUpper();
            objEntidad.tipoDocumento = txtTipoDocumento.Text.ToUpper();
            objEntidad.documento = txtDocumento.Text.ToUpper();
            objEntidad.telefono = txtTelefono.Text.ToUpper();
            objEntidad.correo = txtCorreo.Text.ToUpper();
            objEntidad.fechaIngreso = Convert.ToDateTime(txtFechaIngreso.Text);
            objNegocio.InsertandoClienteBD(objEntidad);

            MessageBox.Show("Cliente registrado correctamente");
            MostrarBuscarBD("");
            LimpiarCampos();
        }

        public void MostrarBuscarBD(string buscar)
        {
          
            tablaCliente.DataSource = objNegocio.BuscarClienteBD(buscar);

        }

        public void LimpiarCampos()
        {
            txtCodCliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtSexo.Text = "";
            txtTipoDocumento.Text = "";
            txtDocumento.Text = "";
            txtCorreo.Text = "";
            txtFechaIngreso.Text = "";

            
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            MostrarBuscarBD("");
            //tablaCliente.ClearSelection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarBD(txtBuscar.Text);
        }
    }
    
}
