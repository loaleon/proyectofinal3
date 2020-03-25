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
    public partial class frmDepartamento : Form
    {
        EDepartamento objEntidad = new EDepartamento();
        NDepartamento objNegocio = new NDepartamento();
        public frmDepartamento()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Los campos no pueden estar en blanco","Sistema de Venta", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    objEntidad.nombre = txtNombre.Text.ToUpper();
                    objNegocio.InsertandoDepartamentoBD(objEntidad);
                     MessageBox.Show("Registro grabado correctamente", "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarBuscarBD("");
                    LimpiarCampos();
                }
                
            

            

        }

        public void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";

        }

        public void MostrarBuscarBD(string buscar)
        {
            tablaDepartamento.DataSource = objNegocio.BuscarDepartamentoBD(buscar);

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Registro no exixte");
            }
            else
            {
               
                objEntidad.nombre = txtNombre.Text.ToUpper();
                
                objNegocio.EliminandoDepartamentoBD(objEntidad);

                MessageBox.Show("Cliente eliminado");
                MostrarBuscarBD("");
                LimpiarCampos();
            }

        }

        private void tablaDepartamento_DoubleClick(object sender, EventArgs e)
        {
            if (tablaDepartamento.SelectedRows.Count > 0)
            {
                txtCodigo.Text = tablaDepartamento.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = tablaDepartamento.CurrentRow.Cells[1].Value.ToString();
                

                
                tabDepartamento.SelectedIndex = 1;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                objEntidad.idDepartamento = Convert.ToInt32(txtCodigo.Text);
                objEntidad.nombre = txtNombre.Text.ToUpper();

                
                DialogResult Resultado;
               Resultado = MessageBox.Show("Esta seguro que deseas eliminar el registro", "Sistema de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
               
                if (Resultado == DialogResult.OK)
                {
                    objNegocio.EliminandoDepartamentoBD(objEntidad);
                    MostrarBuscarBD("");
                    LimpiarCampos();
                }
              
            }
            catch
            {
                MessageBox.Show("Los campos no pueden estar en blanco", "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                   
        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {
            MostrarBuscarBD("");
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
          try
            {
                objEntidad.idDepartamento = Convert.ToInt32(txtCodigo.Text);
                objEntidad.nombre = txtNombre.Text.ToUpper();

                DialogResult Respuesta;
                Respuesta = MessageBox.Show("Deseas modificar el registro", "Sistema de Venta",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (Respuesta == DialogResult.OK)
                {
                    objNegocio.ActualizarDepartamentoBD(objEntidad);
                    MostrarBuscarBD("");
                    LimpiarCampos();
                }      
            }  
           catch
            {
                MessageBox.Show("Los campos no pueden estar en blanco", "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarBD(txtBuscar.Text);
        }
    }
}
