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
    public partial class frmTipoProducto : Form
    {
        ETipoProducto objEntidad = new ETipoProducto();
        NTipoProducto objNegocio = new NTipoProducto();
        public frmTipoProducto()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtemailempleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("No puede tener campos en blanco", "Sistema de Venta", MessageBoxButtons.OK,MessageBoxIcon.Error);


            }
            else
            {
                objEntidad.nombre = txtNombre.Text.ToUpper();
                objEntidad.descripcion = txtDescripcion.Text.ToUpper();

                objNegocio.InsertandoTipoProductoBD(objEntidad);

                MessageBox.Show("Registro ingresado correctamente", "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarBuscarBD("");
                LimpiarCampos();

            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Tipo de producto no registrado", "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                objEntidad.idTipoProd = Convert.ToInt32(txtCodigo.Text);
                objEntidad.nombre = txtNombre.Text.ToUpper();
                objEntidad.descripcion = txtDescripcion.Text.ToUpper();

                
                DialogResult Respuesta;
               Respuesta = MessageBox.Show("Deseas modificar el registro", "Siste de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
               
                if (Respuesta == DialogResult.OK)
                {
                    objNegocio.ActualizarTipoProductoBD(objEntidad);
                    MostrarBuscarBD("");
                    LimpiarCampos();
                }
                

            }
        }

        public void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }
        public void MostrarBuscarBD(string buscar)
        {
            tablaTipoProducto.DataSource = objNegocio.BuscarTipoProductoBD(buscar);
        }

        private void frmTipoProducto_Load(object sender, EventArgs e)
        {
            MostrarBuscarBD("");
            tablaTipoProducto.ClearSelection();

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Tipo de producto no registrado", "Sistema de Venta",MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                objEntidad.idTipoProd = Convert.ToInt32(txtCodigo.Text);
                objEntidad.nombre = txtNombre.Text.ToUpper();
                objEntidad.descripcion = txtDescripcion.Text.ToUpper();


                DialogResult Respuesta;

               Respuesta = MessageBox.Show("Estas seguro de eliminar el registro", "Sistema de Venta", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                
                if (Respuesta == DialogResult.OK)
                {

                    objNegocio.EliminandoTipoProductoBD(objEntidad);
                    MostrarBuscarBD("");
                    LimpiarCampos();
                }

               
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
        }

        private void tablaTipoProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void tablaTipoProducto_DoubleClick(object sender, EventArgs e)
        {
            if (tablaTipoProducto.SelectedRows.Count > 0)
            {
                txtCodigo.Text = tablaTipoProducto.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = tablaTipoProducto.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = tablaTipoProducto.CurrentRow.Cells[2].Value.ToString();
                tabTipoProducto.SelectedIndex = 1;

            }
        }
    }
}
