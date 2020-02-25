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
    public partial class frmRRHH : Form
    {
        Empleado objEntidad = new Empleado();
        NEmpleado objNegocio = new NEmpleado();
        public frmRRHH()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnterrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRRHH_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objEntidad.nombre = txtNombre.Text;
            objEntidad.apellido = txtapeempleado.Text;
            objEntidad.tipoDocumento = txtTipoDocumento.Text;
            objEntidad.documento = txtDocumento.Text;
            objEntidad.direccion = txtdirecempleado.Text;
            objEntidad.sexo = txtGenero.Text;
            objEntidad.telefono = txttelempleado.Text;
            objEntidad.correo = txtemailempleado.Text;
            objEntidad.idDepartamento = Convert.ToInt32(txtDepartamento.Text);
            objEntidad.fechaIngreso = Convert.ToDateTime(txtFechaIngreso.Text);
            objEntidad.fechaNacimiento = Convert.ToDateTime(txtfechaNacimiento.Text);

            objNegocio.InsertandoEmpleadoBD(objEntidad);


            
        }
    }
}
