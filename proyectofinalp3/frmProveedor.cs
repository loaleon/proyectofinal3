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
    public partial class frmProveedor : Form
    {
        EProveedor objEntidad = new EProveedor();
        NProveedor objNegocio = new NProveedor();

        public frmProveedor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {   
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtRazonSocial.Text) || string.IsNullOrEmpty(txtDireccion.Text)
               || string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtTipoDocumento.Text) || string.IsNullOrEmpty(txtDocumento.Text)
               || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Los campos no pueden estar en blanco", "Sistema de venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                else
                {
                        objEntidad.nombre = txtNombre.Text.ToUpper();
                        objEntidad.razonSocial = txtRazonSocial.Text.ToUpper();
                        objEntidad.direccion = txtDireccion.Text.ToUpper();
                        objEntidad.tipoDocumento = txtTipoDocumento.Text.ToUpper();
                        objEntidad.documento = txtDocumento.Text.ToUpper();
                        objEntidad.telefono = txtTelefono.Text.ToUpper();
                        objEntidad.correo = txtCorreo.Text.ToUpper();
                        objEntidad.fecha = Convert.ToDateTime(txtFecha.Text);

                        objNegocio.InsertandoProveedorBD(objEntidad);

                        MessageBox.Show("Proveedor registrado correctamente", "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MostrarBuscarBD("");
                        LipiarCampos();
                }    

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void txtemailempleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            MostrarBuscarBD("");
        }

        public void LipiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtRazonSocial.Text = "";
            txtDireccion.Text = "";
            txtTipoDocumento.Text = "";
            txtDocumento.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtFecha.Text = "";
        }

        public void MostrarBuscarBD(string buscar)
        {
            tablaProveedor.DataSource = objNegocio.BuscarProveedorBD(buscar);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                objEntidad.idProveedor = Convert.ToInt32(txtCodigo.Text);
                objEntidad.nombre = txtNombre.Text.ToUpper();
                objEntidad.razonSocial = txtRazonSocial.Text.ToUpper();
                objEntidad.direccion = txtDireccion.Text.ToUpper();
                objEntidad.tipoDocumento = txtTipoDocumento.Text.ToUpper();
                objEntidad.documento = txtDocumento.Text.ToUpper();
                objEntidad.telefono = txtTelefono.Text;
                objEntidad.correo = txtCorreo.Text.ToUpper();
                objEntidad.fecha = Convert.ToDateTime(txtFecha.Text);

              

                DialogResult Respuesta;

               Respuesta =  MessageBox.Show("Deseas actualizar el registro", "Sistema Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Respuesta == DialogResult.OK)
                {
                    objNegocio.ActualizarProveedorBD(objEntidad);
                    MostrarBuscarBD("");
                    LipiarCampos();
                }
                
            }

            catch
            {
                MessageBox.Show("Registro no existe", "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarBD(txtBuscar.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objEntidad.idProveedor = Convert.ToInt32(txtCodigo.Text);
                objEntidad.nombre = txtNombre.Text;
                objEntidad.razonSocial = txtRazonSocial.Text;
                objEntidad.direccion = txtDireccion.Text;
                objEntidad.tipoDocumento = txtTipoDocumento.Text;
                objEntidad.documento = txtDocumento.Text;
                objEntidad.telefono = txtTelefono.Text;
                objEntidad.correo = txtCorreo.Text;
                objEntidad.fecha = Convert.ToDateTime(txtFecha.Text);

                DialogResult Resultado;

               Resultado = MessageBox.Show("Estas seguro de eliminar el registro", "Sistema Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
               if (Resultado == DialogResult.OK)
                {
                    objNegocio.EliminandoProveedorBD(objEntidad);
                    MostrarBuscarBD("");
                    LipiarCampos();
                }
                
               
            }
            
            catch
            {
                MessageBox.Show("Registro no existe", "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
          
        }

        private void tablaProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LipiarCampos();
        }

        private void tablaProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaProveedor.SelectedRows.Count > 0)
            {
                txtCodigo.Text = tablaProveedor.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = tablaProveedor.CurrentRow.Cells[1].Value.ToString();
                txtRazonSocial.Text = tablaProveedor.CurrentRow.Cells[2].Value.ToString();
                txtDireccion.Text = tablaProveedor.CurrentRow.Cells[3].Value.ToString();
                txtTipoDocumento.Text = tablaProveedor.CurrentRow.Cells[4].Value.ToString();
                txtDocumento.Text = tablaProveedor.CurrentRow.Cells[5].Value.ToString();
                txtTelefono.Text = tablaProveedor.CurrentRow.Cells[6].Value.ToString();
                txtCorreo.Text = tablaProveedor.CurrentRow.Cells[7].Value.ToString();
                txtFecha.Text = tablaProveedor.CurrentRow.Cells[8].Value.ToString();

             
                tabProveedor.SelectedIndex = 1;
            }
        }
    }
}
