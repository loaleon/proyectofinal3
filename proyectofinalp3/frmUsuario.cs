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
   
    public partial class frmUsuario : Form
    {

        EUsuario objEntidad = new EUsuario();
        NUsuario objNegocio = new NUsuario();
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            objEntidad.usuario = txtNombre.Text;
            objEntidad.contrasena = txtContrasena.Text;
            objEntidad.idEmpleado = Convert.ToInt32(txtEmpleado.Text);

            objNegocio.InsertandoUsuarioBD(objEntidad);
            MessageBox.Show("Usuario registrado correctamente");
            
            MostrarBuscarBD("");
            LimpiarCampos();

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            MostrarBuscarBD("");
        
          tablaUsuario.ClearSelection();
        }
        public void MostrarBuscarBD(string buscar)
        {

            tablaUsuario.DataSource = objNegocio.BuscarUsuarioBD(buscar);

        }

        private void btnAgregar_Click(object sendroger, EventArgs e)
        {
          
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objEntidad.idUsuario = Convert.ToInt32(txtCodigo.Text);
            objEntidad.usuario = txtNombre.Text;
            objEntidad.contrasena = txtContrasena.Text;
            objEntidad.idEmpleado = Convert.ToInt32(txtEmpleado.Text);

            objNegocio.ActualizarUsuarioBD(objEntidad);
            MessageBox.Show("Usuario actualizado correctamente");

            MostrarBuscarBD("");
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtContrasena.Text = "";
            txtEmpleado.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objEntidad.usuario = txtNombre.Text;
            objEntidad.contrasena = txtContrasena.Text;
            objEntidad.idEmpleado = Convert.ToInt32(txtEmpleado.Text);

            objNegocio.EliminandoUsuarioBD(objEntidad);
            MessageBox.Show("Usuario elimiando correctamente");

            MostrarBuscarBD("");
            LimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tablaUsuario_DoubleClick(object sender, EventArgs e)
        {
            if (tablaUsuario.SelectedRows.Count > 0)
            {
                txtCodigo.Text = tablaUsuario.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = tablaUsuario.CurrentRow.Cells[1].Value.ToString();
                txtContrasena.Text = tablaUsuario.CurrentRow.Cells[2].Value.ToString();
                txtEmpleado.Text = tablaUsuario.CurrentRow.Cells[3].Value.ToString();
                tabUsuario.SelectedIndex = 1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarBD(txtBuscar.Text);
        }
    }
}
