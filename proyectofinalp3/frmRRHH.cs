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
            CargareEmpleadoBox();
            tablaEmpleado.ClearSelection();
        }
        public void MostrarBuscarBD(string buscar)
        {
            
            tablaEmpleado.DataSource = objNegocio.BuscarEmpleadoBD(buscar);

        }
        public void CargareEmpleadoBox()
        {
            
            cboDepartamento.ValueMember = "idDepartamento";
            cboDepartamento.DisplayMember = "nombre";
            cboDepartamento.DataSource = objNegocio.SeleccionarDepartamento();
            MostrarBuscarBD("");

        }

            private void btnAgregar_Click(object sender, EventArgs e)
            {
                
                     
                        if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtapeempleado.Text) ||
                            string.IsNullOrEmpty(txtdirecempleado.Text) || string.IsNullOrEmpty(txtTipoDocumento.Text) ||
                            string.IsNullOrEmpty(txtDocumento.Text) || string.IsNullOrEmpty(txttelempleado.Text) ||
                            string.IsNullOrEmpty(txtemailempleado.Text) || string.IsNullOrEmpty(txtGenero.Text) ||
                            string.IsNullOrEmpty(cboDepartamento.Text))
                        {

                            MessageBox.Show("Los campos no pueden estar en blanco", "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            

                        }
                    else
                    {
                    objEntidad.nombre = txtNombre.Text;
                    objEntidad.apellido = txtapeempleado.Text;
                    objEntidad.tipoDocumento = txtTipoDocumento.Text;
                    objEntidad.documento = txtDocumento.Text;
                    objEntidad.direccion = txtdirecempleado.Text;
                    objEntidad.sexo = txtGenero.Text;
                    objEntidad.telefono = txttelempleado.Text;
                    objEntidad.correo = txtemailempleado.Text;
                    objEntidad.idDepartamento = Convert.ToInt32(((System.Data.DataRowView)cboDepartamento.SelectedItem).Row[0]);
                    objEntidad.fechaIngreso = Convert.ToDateTime(txtFechaIngreso.Text);
                    objEntidad.fechaNacimiento = Convert.ToDateTime(txtfechaNacimiento.Text);

                    objNegocio.InsertandoEmpleadoBD(objEntidad);
                    MessageBox.Show("Empleado agregado correctamente", "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarBuscarBD("");
                    LimpiarCampos();

                                                                                                                
                    }

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
            cboDepartamento.Text = "";
            txtFechaIngreso.Text = "";
            txtfechaNacimiento.Text = "";



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
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
                objEntidad.idDepartamento = Convert.ToInt32(((System.Data.DataRowView)cboDepartamento.SelectedItem).Row[0]);
                objEntidad.fechaIngreso = Convert.ToDateTime(txtFechaIngreso.Text);
                objEntidad.fechaNacimiento = Convert.ToDateTime(txtfechaNacimiento.Text);

                DialogResult Respuesta;
                Respuesta = MessageBox.Show("Deseas actualizar el registro", "Sistema de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
                if (Respuesta == DialogResult.OK)
                {
                    objNegocio.ActualizarEmpleadoBD(objEntidad);
                    MostrarBuscarBD("");
                    LimpiarCampos();
                }
                
            }

            catch
            {
                MessageBox.Show("Empleado no existe", "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
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
                objEntidad.idDepartamento = Convert.ToInt32(cboDepartamento.Text);
                objEntidad.fechaIngreso = Convert.ToDateTime(txtFechaIngreso.Text);
                objEntidad.fechaNacimiento = Convert.ToDateTime(txtfechaNacimiento.Text);

                
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("Esta seguro de eliminar el registro", "Sistema de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (Respuesta == DialogResult.OK)
                {
                    objNegocio.EliminandoEmpleadoBD(objEntidad);
                    MostrarBuscarBD("");
                    LimpiarCampos();
                }
            }
                
               

            catch
            {
                MessageBox.Show("Empledo no existe", "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void txtTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tablaEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void tablaEmpleado_DoubleClick(object sender, EventArgs e)
        {
            if (tablaEmpleado.SelectedRows.Count > 0)
            {

                txtCodEmpleado.Text = tablaEmpleado.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = tablaEmpleado.CurrentRow.Cells[1].Value.ToString();
                txtapeempleado.Text = tablaEmpleado.CurrentRow.Cells[2].Value.ToString();
                txtTipoDocumento.Text = tablaEmpleado.CurrentRow.Cells[3].Value.ToString();
                txtDocumento.Text = tablaEmpleado.CurrentRow.Cells[4].Value.ToString(); ;
                txtdirecempleado.Text = tablaEmpleado.CurrentRow.Cells[5].Value.ToString();
                txtGenero.Text = tablaEmpleado.CurrentRow.Cells[6].Value.ToString();
                txttelempleado.Text = tablaEmpleado.CurrentRow.Cells[7].Value.ToString(); ;
                txtemailempleado.Text = tablaEmpleado.CurrentRow.Cells[8].Value.ToString();
                cboDepartamento.Text = tablaEmpleado.CurrentRow.Cells[9].Value.ToString();
                txtFechaIngreso.Text = tablaEmpleado.CurrentRow.Cells[10].Value.ToString();
                txtfechaNacimiento.Text = tablaEmpleado.CurrentRow.Cells[11].Value.ToString();

                MostrarBuscarBD("");
                tabEmpleado.SelectedIndex = 1;

            }
        }
    }
}
