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
        private string idEmpleado;
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
            if (tablaEmpleado.SelectedRows.Count > 0)
            {
                idEmpleado = tablaEmpleado.CurrentRow.Cells[0].Value.ToString();
                txtCodEmpleado.Text = tablaEmpleado.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = tablaEmpleado.CurrentRow.Cells[1].Value.ToString();
                txtapeempleado.Text = tablaEmpleado.CurrentRow.Cells[2].Value.ToString();
                txtTipoDocumento.Text = tablaEmpleado.CurrentRow.Cells[3].Value.ToString();
                txtDocumento.Text = tablaEmpleado.CurrentRow.Cells[4].Value.ToString(); ;
                txtdirecempleado.Text = tablaEmpleado.CurrentRow.Cells[5].Value.ToString();
                txtGenero.Text = tablaEmpleado.CurrentRow.Cells[6].Value.ToString();
                txttelempleado.Text = tablaEmpleado.CurrentRow.Cells[7].Value.ToString(); ;
                txtemailempleado.Text = tablaEmpleado.CurrentRow.Cells[8].Value.ToString();
                txtDepartamento.Text = tablaEmpleado.CurrentRow.Cells[9].Value.ToString();
                txtFechaIngreso.Text = tablaEmpleado.CurrentRow.Cells[10].Value.ToString();
                txtfechaNacimiento.Text = tablaEmpleado.CurrentRow.Cells[11].Value.ToString();

                MessageBox.Show("Registro seleccionado");
                tabEmpleado.SelectedIndex = 0;

            }
            else
            {
                MessageBox.Show("Seleccione el registro a modificar");
            }
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
            MostrarBuscarBD("");
            tablaEmpleado.ClearSelection();
        }
        public void MostrarBuscarBD(string buscar)
        {
            //NEmpleado objNegocio = new NEmpleado();
            tablaEmpleado.DataSource = objNegocio.BuscarEmpleadoBD(buscar);

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
            MessageBox.Show("Empleado agregado correctamente");
            MostrarBuscarBD("");
            LimpiarCampos();



        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarBD(txtBuscar.Text);
        }

        public void LimpiarCampos()
        {
            txtCodEmpleado.Text = "";
            txtNombre.Text = "";
            txtapeempleado.Text = ""; 
            txtTipoDocumento.Text = ""; 
            txtDocumento.Text = ""; 
            txtdirecempleado.Text = "";
            txtGenero.Text = "";
            txttelempleado.Text = "";
            txtemailempleado.Text = "";
            txtDepartamento.Text = "";
            txtFechaIngreso.Text = "";
            txtfechaNacimiento.Text = "";



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            objEntidad.idEmpleado = Convert.ToInt32(txtCodEmpleado.Text);
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

            objNegocio.ActualizarEmpleadoBD(objEntidad);
            MessageBox.Show("Emplea actualizado correctamente");
            MostrarBuscarBD("");
            LimpiarCampos();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objEntidad.idEmpleado = Convert.ToInt32(txtCodEmpleado.Text);
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

            objNegocio.EliminandoEmpleadoBD(objEntidad);
            MessageBox.Show("Emplea eliminado correctamente");
            MostrarBuscarBD("");
            LimpiarCampos();
        }

        private void txtTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tablaEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
