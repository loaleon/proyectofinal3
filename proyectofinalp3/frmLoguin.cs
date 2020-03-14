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
using proyectofinalp3;


namespace proyectofinalp3
{
    public partial class frmLoguin : Form
    {

        EUsuario objEntidad = new EUsuario();
        NUsuario objNegocio = new NUsuario();
        public frmLoguin()
        {
            InitializeComponent();
        }

        private void Loguin_Load(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = new DataTable();
                NUsuario objNegocio = new NUsuario();
                tabla = NUsuario.Login(txtusuario.Text.Trim(), txtclave.Text.Trim());

                if (tabla.Rows.Count <= 0){

                    MessageBox.Show("Usuario o Constraseña es incorrecta.", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    frmPrincipal miforma = new frmPrincipal();
                    miforma.idUsuario = Convert.ToInt32(tabla.Rows[0][0]);
                    miforma.idEmpleado = Convert.ToInt32(tabla.Rows[0][1]);
                    miforma.usuario = Convert.ToString(tabla.Rows[0][2]);
                    miforma.idDepartamento = Convert.ToInt32(tabla.Rows[0][4]);
                    miforma.nombre = Convert.ToString(tabla.Rows[0][5]); 


                    miforma.Show();
                    this.Hide();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
