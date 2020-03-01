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
            objEntidad.nombre = txtNombre.Text.ToUpper();
            objEntidad.razonSocial = txtRazonSocial.Text.ToUpper();
            objEntidad.direccion = txtDireccion.Text.ToUpper();
            objEntidad.tipoDocumento = txtTipoDocumento.Text.ToUpper();
            objEntidad.documento = txtDocumento.Text.ToUpper();
            objEntidad.telefono = txtTelefono.Text.ToUpper();
            objEntidad.correo = txtCorreo.Text.ToUpper();
            objEntidad.fecha =  Convert.ToDateTime(txtFecha.Text);

            objNegocio.InsertandoProveedorBD(objEntidad);

            MessageBox.Show("Proveedor registrado correctamente");
     
            MostrarBuscarBD("");
            LipiarCampos();
            

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
            objEntidad.idProveedor = Convert.ToInt32(txtCodigo.Text);
            objEntidad.nombre = txtNombre.Text.ToUpper();
            objEntidad.razonSocial = txtRazonSocial.Text.ToUpper();
            objEntidad.direccion = txtDireccion.Text.ToUpper();
            objEntidad.tipoDocumento = txtTipoDocumento.Text.ToUpper();
            objEntidad.documento = txtDocumento.Text.ToUpper();
            objEntidad.telefono = txtTelefono.Text;
            objEntidad.correo = txtCorreo.Text.ToUpper();
            objEntidad.fecha = Convert.ToDateTime(txtFecha.Text);

            objNegocio.ActualizarProveedorBD(objEntidad);

            MessageBox.Show("Registro actualizado correctamente");
            
            MostrarBuscarBD("");
            LipiarCampos();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarBD(txtBuscar.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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

            objNegocio.EliminandoProveedorBD(objEntidad);

            MessageBox.Show("Registro eliminado correctamente");
            MostrarBuscarBD("");
            LipiarCampos();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
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

                MessageBox.Show("Registro seleccionado");
                tabProveedor.SelectedIndex = 0;
            }
            else
            {

            }
            
        }

        private void tablaProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
