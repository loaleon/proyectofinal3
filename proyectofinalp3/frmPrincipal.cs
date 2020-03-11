using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectofinalp3
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnpresupuestos_Click(object sender, EventArgs e)
        {
        }
        private void btnalmacen_Click(object sender, EventArgs e)
        {
        }
        private void btnvvendedor_Click(object sender, EventArgs e)
        {
        }
        private void btnclientes_Click(object sender, EventArgs e)
        {
            frmClientes miforma = new frmClientes();
            miforma.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes miforma = new frmClientes();
            miforma.Show();
        }

        private void crearPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void presupuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContabilidad miforma = new frmContabilidad();
            miforma.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionDeVendedores miforma = new frmGestionDeVendedores();
            miforma.Show();
        }

        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionDeVendedores miforma = new frmGestionDeVendedores();
            miforma.Show();
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionDeVendedores miforma = new frmGestionDeVendedores();
            miforma.Show();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto miforma = new frmProducto();
            miforma.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmClientes miforma = new frmClientes();
            miforma.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmGestionDeVendedores miforma = new frmGestionDeVendedores();
            miforma.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmContabilidad miforma = new frmContabilidad();
            miforma.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmContabilidad miforma = new frmContabilidad();
            miforma.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            frmProducto miforma = new frmProducto();
            miforma.Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            frmProducto miforma = new frmProducto();
            miforma.Show();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes miforma = new frmClientes();
            miforma.Show();
        }

        private void crearClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionDeVendedores miforma = new frmGestionDeVendedores();
            miforma.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmGestionDeVendedores miforma = new frmGestionDeVendedores();
            miforma.Show();
        }

        private void verCluentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verPresupuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionDeVendedores miforma = new frmGestionDeVendedores();
            miforma.Show();
        }

        private void toolStripMenuItem5_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmProducto miforma = new frmProducto();
            miforma.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            frmContabilidad miforma = new frmContabilidad();
            miforma.Show();
        }

        private void toolStripMenuItem10_Click_1(object sender, EventArgs e)
        {
            frmRRHH miforma = new frmRRHH();
            miforma.Show();
        }

        private void toolStripMenuItem14_Click_1(object sender, EventArgs e)
        {
            frmGestionDeVendedores miforma = new frmGestionDeVendedores();

            miforma.tabpresupuesto.TabPages[2].Show();

            miforma.Show();

        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            frmRRHH miforma = new frmRRHH();
            miforma.Show();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            frmClientes miforma = new frmClientes();
            miforma.Show();
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            frmDespacho miforma = new frmDespacho();
            miforma.Show();


        }

        private void toolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            frmProducto miforma = new frmProducto();
            miforma.Show();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            frmVentas miforma = new frmVentas();
            miforma.Show();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem10_Click_2(object sender, EventArgs e)
        {
            // frmFormularios miforma = new Formularios();
            //miforma.Show();
        }

        private void toolStripMenuItem9_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem9_Click_2(object sender, EventArgs e)
        {
            frmProveedor miforma = new frmProveedor();
            miforma.Show();
        }

        private void tipoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoProducto miforma = new frmTipoProducto();
            miforma.Show();
        }

        private void toolStripMenuItem5_Click_2(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click_2(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem9_Click_3(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accesoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario miforma = new frmUsuario();
            miforma.Show();
        }
    }
}
