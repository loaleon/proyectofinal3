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
    public partial class frmProducto : Form
    {
        EProducto objEntidad = new EProducto();
        NProducto objNegocio = new NProducto();

        public frmProducto()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnentrada_Click(object sender, EventArgs e)
        {
            frmRRHH miforma = new frmRRHH();
            
                
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
          

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        internal static TabControl TabControl()
        {
            throw new NotImplementedException();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            objEntidad.nombreProd = txtNombreProd.Text.ToUpper();
            objEntidad.idTipoProd = Convert.ToInt32(txtTipoProducto.Text);
            objEntidad.descripcion = txtDescripcion.Text.ToUpper();
            objEntidad.idProveedor = Convert.ToInt32(txtProveedor.Text.ToUpper());
            objEntidad.precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
            objEntidad.precioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            objEntidad.prodMax = Convert.ToInt32(txtStockMax.Text);
            objEntidad.prodMin = Convert.ToInt32(txtStockMin.Text);
            objEntidad.fechaIngreso = Convert.ToDateTime(txtFecha.Text);

            objNegocio.InsertandoProductoBD(objEntidad);

            MessageBox.Show("Registro ingresado correctamente");
            MostrarBuscarBD("");
            LimpiarCampos();
        }
        public void MostrarBuscarBD(string buscar)
        {
            tablaProducto.DataSource = objNegocio.BuscarProductoBD(buscar);
        }
        public void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombreProd.Text = "";
            txtTipoProducto.Text = "";
            txtDescripcion.Text = "";
            txtProveedor.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtStockMax.Text = "";
            txtStockMin.Text = "";
            txtFecha.Text = "";

        }
    }
}

