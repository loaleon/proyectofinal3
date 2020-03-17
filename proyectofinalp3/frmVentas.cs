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
    public partial class frmVentas : Form
    {
        //public int idCliente;
        //public string nombre;
        //public string apellido;
        /*
        private static frmVentas _instancia;


        public static frmVentas GetIntacia()
        {
            if (_instancia == null)
            {
                _instancia = new frmVentas();
            }
            return _instancia;
        }

        public void setCliente(string idCliente, string nombre, string apellido)
        {
            this.txtCodigo.Text = idCliente;
            this.txtNombre.Text = nombre;
            this.txtApellido.Text = apellido;
        }

    */

   
        public frmVentas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscarCliente miforma = new frmBuscarCliente();
            miforma.ShowDialog();
            txtCodigo.Text = Convert.ToString(Variables.idCliente);
            txtNombre.Text = Variables.nombre;
            txtApellido.Text = Variables.apellido;
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            
        }

        private void frmVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_instancia = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBuscarProducto miforma = new frmBuscarProducto();
            miforma.ShowDialog();
            txtProducto.Text = Variables.nombreProd;
            txtCompra.Text = Convert.ToString(Variables.precioCompra);
            txtVenta.Text = Convert.ToString(Variables.precioVenta);
            txtStock.Text = Convert.ToString(Variables.stock);
            miforma.Show();




        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
