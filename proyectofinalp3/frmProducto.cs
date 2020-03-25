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
            MostrarBuscarBD("");
            CargarBox();
            CargarProveedorBox();
        }
        public void CargarBox()
        {

           
            cboTipoProducto.ValueMember = "idTipoProd";
            cboTipoProducto.DisplayMember = "nombre";
            cboTipoProducto.DataSource = objNegocio.Seleccionar();
            

        }
        public void CargarProveedorBox()
        {
            
            cboProveedor.ValueMember = "idProveedor";
            cboProveedor.DisplayMember = "nombre";
            cboProveedor.DataSource = objNegocio.SeleccionarProveedorBox();

        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                objEntidad.nombreProd = txtNombreProd.Text.ToUpper();
                objEntidad.idTipoProd = Convert.ToInt32(((System.Data.DataRowView)cboTipoProducto.SelectedItem).Row[0]);
                objEntidad.idProveedor = Convert.ToInt32(((System.Data.DataRowView)cboProveedor.SelectedItem).Row[0]);
                objEntidad.precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                objEntidad.precioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                objEntidad.prodMax = Convert.ToInt32(txtStockMax.Text);
                objEntidad.prodMin = Convert.ToInt32(txtStockMin.Text);
                objEntidad.fechaIngreso = Convert.ToDateTime(txtFecha.Text);

                objNegocio.InsertandoProductoBD(objEntidad);

                MessageBox.Show("Registro ingresado correctamente", "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarBuscarBD("");
                LimpiarCampos();
            }
          

            catch 
            {
                MessageBox.Show("Los campos no pueden estar en blanco", "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
        public void MostrarBuscarBD(string buscar)
        {
            tablaProducto.DataSource = objNegocio.BuscarProductoBD(buscar);
        }
     
       
        public void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombreProd.Text = "";
            cboTipoProducto.Text = "";
            cboProveedor.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtStockMax.Text = "";
            txtStockMin.Text = "";
            txtFecha.Text = "";

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                 
                    MessageBox.Show("Producto no registrado", "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    objEntidad.idProducto = Convert.ToInt32(txtCodigo.Text);
                    objEntidad.nombreProd = txtNombreProd.Text.ToUpper();
                    objEntidad.idTipoProd = Convert.ToInt32(((System.Data.DataRowView)cboTipoProducto.SelectedItem).Row[0]);
                    objEntidad.idProveedor = Convert.ToInt32(((System.Data.DataRowView)cboProveedor.SelectedItem).Row[0]);
                    objEntidad.precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                    objEntidad.precioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                    objEntidad.prodMax = Convert.ToInt32(txtStockMax.Text);
                    objEntidad.prodMin = Convert.ToInt32(txtStockMin.Text);
                    objEntidad.fechaIngreso = Convert.ToDateTime(txtFecha.Text);

                    
                    DialogResult Respuesta;

                   Respuesta = MessageBox.Show("Estas seguro de modificar el registro", "Sistema Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(Respuesta == DialogResult.OK)
                    {
                        objNegocio.ActualizarProductoBD(objEntidad);
                        MostrarBuscarBD("");
                        LimpiarCampos();
                    }
                    
                    
                }
                
           
            }

            catch
            {
               
                MessageBox.Show("Producto no existe", "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           try
            {
                
                   objEntidad.idProducto = Convert.ToInt32(txtCodigo.Text);
                    objEntidad.nombreProd = txtNombreProd.Text;
                    objEntidad.idTipoProd = Convert.ToInt32(cboTipoProducto.Text);
                    objEntidad.idProveedor = Convert.ToInt32(cboProveedor.Text);
                    objEntidad.precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                    objEntidad.precioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                    objEntidad.prodMax = Convert.ToInt32(txtStockMax.Text);
                    objEntidad.prodMin = Convert.ToInt32(txtStockMin.Text);
                    objEntidad.fechaIngreso = Convert.ToDateTime(txtFecha.Text);

                    

                //Respuesta = MessageBox.Show("Esta seguro que quieres eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);  
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("Deseas elimar Producto", "Sistema de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Respuesta == DialogResult.OK)
                {
                    objNegocio.EliminandoProductoBD(objEntidad);
                    MostrarBuscarBD("");
                    LimpiarCampos();
                }

              
            }
            catch
            {
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("Producto no existe", "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void tablaProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaProducto.SelectedRows.Count > 0)
            {
                txtCodigo.Text = tablaProducto.CurrentRow.Cells[0].Value.ToString();
                txtNombreProd.Text = tablaProducto.CurrentRow.Cells[1].Value.ToString();
                cboTipoProducto.Text = tablaProducto.CurrentRow.Cells[2].Value.ToString();
                cboProveedor.Text = tablaProducto.CurrentRow.Cells[3].Value.ToString();
                txtPrecioCompra.Text = tablaProducto.CurrentRow.Cells[4].Value.ToString();
                txtPrecioVenta.Text = tablaProducto.CurrentRow.Cells[5].Value.ToString();
                txtStockMax.Text = tablaProducto.CurrentRow.Cells[6].Value.ToString();
                txtStockMin.Text = tablaProducto.CurrentRow.Cells[7].Value.ToString();
                txtFecha.Text = tablaProducto.CurrentRow.Cells[8].Value.ToString();

               
                tabProducto.SelectedIndex = 1;
            }
        }

        private void tablaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablaProducto_DoubleClick(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarBD(txtBuscar.Text);
        }
    }
    
}

