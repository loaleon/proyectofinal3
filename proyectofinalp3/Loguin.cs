﻿using System;
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
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }

        private void Loguin_Load(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "admin" && txtclave.Text == "1234")
            {
                Form1 miforma = new Form1();
                miforma.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Los datos introducidos no coinciden… intente de nuevo");
                txtusuario.Text = "";
                txtclave.Text = "";
                txtusuario.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}