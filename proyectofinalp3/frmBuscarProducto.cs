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
    public partial class frmBuscarProducto : Form
    {
        EProducto objEntidad = new EProducto();
        NProducto objNegocio = new NProducto();

        public void MostrarBuscarProductoBD(string buscar)
        {

         tablaProductoB.DataSource = objNegocio.BuscarProductoBD(buscar);

           

        }

        

        public frmBuscarProducto()
        {
            InitializeComponent();
        }

        private void frmBuscarProducto_Load(object sender, EventArgs e)
        {
            MostrarBuscarProductoBD("");


            tablaProductoB.Columns[2].Visible = false;
            tablaProductoB.Columns[3].Visible = false;
            tablaProductoB.Columns[7].Visible = false;
        }

        private void FormatoAticulos()
        {
           
            
        }

        private void tablaProductoB_DoubleClick(object sender, EventArgs e)
        {
            Variables.nombreProd = Convert.ToString(tablaProductoB.CurrentRow.Cells["nombreProd"].Value);
            Variables.precioCompra = Convert.ToDecimal(tablaProductoB.CurrentRow.Cells["precioCompra"].Value);
            Variables.precioVenta = Convert.ToDecimal(tablaProductoB.CurrentRow.Cells["precioVenta"].Value);
            Variables.stock = Convert.ToInt32(tablaProductoB.CurrentRow.Cells["prodMax"].Value);
            this.Close();
        }
    }
}
