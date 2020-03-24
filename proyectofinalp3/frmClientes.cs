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
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtDireccion.Text)
                || string.IsNullOrEmpty(txtSexo.Text) || string.IsNullOrEmpty(txtTipoDocumento.Text) || string.IsNullOrEmpty(txtDocumento.Text)
                || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Todos los campos debe ser completados", "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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

                MessageBox.Show("Cliente registrado correctamente", "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarBuscarBD("");
                LimpiarCampos();
            }
            
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodCliente.Text))
            {
                MessageBox.Show("Registro no exixte", "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                objEntidad.idCliente = Convert.ToInt32(txtCodCliente.Text);
                objEntidad.nombre = txtNombre.Text.ToUpper();
                objEntidad.apellido = txtApellido.Text.ToUpper();
                objEntidad.direccion = txtDireccion.Text.ToUpper();
                objEntidad.sexo = txtSexo.Text.ToUpper();
                objEntidad.tipoDocumento = txtTipoDocumento.Text.ToUpper();
                objEntidad.documento = txtDocumento.Text.ToUpper();
                objEntidad.telefono = txtTelefono.Text.ToUpper();
                objEntidad.correo = txtCorreo.Text.ToUpper();
                objEntidad.fechaIngreso = Convert.ToDateTime(txtFechaIngreso.Text);
                
                ;
                DialogResult Respuesta;

               Respuesta = MessageBox.Show("Deseas modificar Cliente", "Sistema Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
               
               if (Respuesta == DialogResult.OK)
                {
                    objNegocio.ActualizarClienteBD(objEntidad);
                    MostrarBuscarBD("");
                    LimpiarCampos();
                }
               
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCodCliente.Text))
            {
                MessageBox.Show("Registro no exixte", "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                objEntidad.idCliente = Convert.ToInt32(txtCodCliente.Text);
                objEntidad.nombre = txtNombre.Text.ToUpper();
                objEntidad.apellido = txtApellido.Text.ToUpper();
                objEntidad.direccion = txtDireccion.Text.ToUpper();
                objEntidad.sexo = txtSexo.Text.ToUpper();
                objEntidad.tipoDocumento = txtTipoDocumento.Text.ToUpper();
                objEntidad.documento = txtDocumento.Text.ToUpper();
                objEntidad.telefono = txtTelefono.Text.ToUpper();
                objEntidad.correo = txtCorreo.Text.ToUpper();
                objEntidad.fechaIngreso = Convert.ToDateTime(txtFechaIngreso.Text);
               

                DialogResult Resultado;
                Resultado =  MessageBox.Show("Deseas eliminar el Cliente", "Sistema Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                
                if (Resultado == DialogResult.OK)
                {
                    objNegocio.EliminandoClienteBD(objEntidad);
                    MostrarBuscarBD("");
                    LimpiarCampos();
                }
                
               
            }

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void tablaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaCliente.SelectedRows.Count > 0)
            {
                txtCodCliente.Text = tablaCliente.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = tablaCliente.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = tablaCliente.CurrentRow.Cells[2].Value.ToString();
                txtTipoDocumento.Text = tablaCliente.CurrentRow.Cells[3].Value.ToString();
                txtDocumento.Text = tablaCliente.CurrentRow.Cells[4].Value.ToString();
                txtDireccion.Text = tablaCliente.CurrentRow.Cells[5].Value.ToString();
                txtTelefono.Text = tablaCliente.CurrentRow.Cells[6].Value.ToString();
                txtCorreo.Text = tablaCliente.CurrentRow.Cells[7].Value.ToString();
                txtSexo.Text = tablaCliente.CurrentRow.Cells[8].Value.ToString();
                txtFechaIngreso.Text = tablaCliente.CurrentRow.Cells[9].Value.ToString();

        
                tabCliente.SelectedIndex = 1;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tablaCliente_DoubleClick(object sender, EventArgs e)
        {

        }
    }
    
}
