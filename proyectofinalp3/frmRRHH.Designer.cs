﻿namespace proyectofinalp3
{
    partial class frmRRHH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRRHH));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.bnterrar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tablaEmpleado = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTipoProducto = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtDepartamento = new System.Windows.Forms.ComboBox();
            this.txtTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.txtfechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodEmpleado = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtemailempleado = new System.Windows.Forms.TextBox();
            this.txtdirecempleado = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txttelempleado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtapeempleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabEmpleado = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleado)).BeginInit();
            this.tabTipoProducto.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(773, 232);
            this.dataGridView1.TabIndex = 93;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(147, 255);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 40);
            this.btnactualizar.TabIndex = 94;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // bnterrar
            // 
            this.bnterrar.Location = new System.Drawing.Point(645, 255);
            this.bnterrar.Name = "bnterrar";
            this.bnterrar.Size = new System.Drawing.Size(75, 40);
            this.bnterrar.TabIndex = 95;
            this.bnterrar.Text = "Cerrar";
            this.bnterrar.UseVisualStyleBackColor = true;
            this.bnterrar.Click += new System.EventHandler(this.bnterrar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.btnSeleccionar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(701, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado Empleados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.txtBuscar);
            this.groupBox8.Controls.Add(this.tablaEmpleado);
            this.groupBox8.Location = new System.Drawing.Point(20, 33);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(660, 297);
            this.groupBox8.TabIndex = 102;
            this.groupBox8.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 100;
            this.label4.Text = "Nombre:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(134, 15);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(254, 32);
            this.txtBuscar.TabIndex = 99;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // tablaEmpleado
            // 
            this.tablaEmpleado.AllowUserToAddRows = false;
            this.tablaEmpleado.AllowUserToDeleteRows = false;
            this.tablaEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaEmpleado.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tablaEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEmpleado.Location = new System.Drawing.Point(20, 53);
            this.tablaEmpleado.Name = "tablaEmpleado";
            this.tablaEmpleado.ReadOnly = true;
            this.tablaEmpleado.RowHeadersVisible = false;
            this.tablaEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaEmpleado.Size = new System.Drawing.Size(615, 231);
            this.tablaEmpleado.TabIndex = 98;
            this.tablaEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaEmpleado_CellContentClick);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(572, 336);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(108, 36);
            this.btnSeleccionar.TabIndex = 92;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(214, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 101;
            this.label1.Text = "Listado de Empleados";
            // 
            // tabTipoProducto
            // 
            this.tabTipoProducto.Controls.Add(this.btnEliminar);
            this.tabTipoProducto.Controls.Add(this.groupBox7);
            this.tabTipoProducto.Controls.Add(this.label7);
            this.tabTipoProducto.Controls.Add(this.btnAgregar);
            this.tabTipoProducto.Controls.Add(this.btnModificar);
            this.tabTipoProducto.Controls.Add(this.btnSalir);
            this.tabTipoProducto.Location = new System.Drawing.Point(4, 22);
            this.tabTipoProducto.Name = "tabTipoProducto";
            this.tabTipoProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tabTipoProducto.Size = new System.Drawing.Size(701, 382);
            this.tabTipoProducto.TabIndex = 0;
            this.tabTipoProducto.Text = "Nuevo Empleado";
            this.tabTipoProducto.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(289, 336);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 36);
            this.btnEliminar.TabIndex = 117;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtDepartamento);
            this.groupBox7.Controls.Add(this.txtTipoDocumento);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.txtDocumento);
            this.groupBox7.Controls.Add(this.txtGenero);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.txtFechaIngreso);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.txtfechaNacimiento);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.txtCodEmpleado);
            this.groupBox7.Controls.Add(this.label);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.txtemailempleado);
            this.groupBox7.Controls.Add(this.txtdirecempleado);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.txttelempleado);
            this.groupBox7.Controls.Add(this.txtNombre);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.txtapeempleado);
            this.groupBox7.Location = new System.Drawing.Point(16, 50);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(659, 277);
            this.groupBox7.TabIndex = 99;
            this.groupBox7.TabStop = false;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.FormattingEnabled = true;
            this.txtDepartamento.Location = new System.Drawing.Point(434, 235);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(141, 21);
            this.txtDepartamento.TabIndex = 132;
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.FormattingEnabled = true;
            this.txtTipoDocumento.Items.AddRange(new object[] {
            "Fememino",
            "Masculino",
            "Otro"});
            this.txtTipoDocumento.Location = new System.Drawing.Point(434, 35);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.Size = new System.Drawing.Size(98, 21);
            this.txtTipoDocumento.TabIndex = 131;
            this.txtTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.txtTipoDocumento_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 129;
            this.label3.Text = "Documento:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(434, 72);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(141, 20);
            this.txtDocumento.TabIndex = 130;
            // 
            // txtGenero
            // 
            this.txtGenero.FormattingEnabled = true;
            this.txtGenero.Items.AddRange(new object[] {
            "Fememino",
            "Masculino",
            "Otro"});
            this.txtGenero.Location = new System.Drawing.Point(434, 204);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(98, 21);
            this.txtGenero.TabIndex = 128;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(363, 202);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 20);
            this.label26.TabIndex = 127;
            this.label26.Text = "Sexo:";
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaIngreso.Location = new System.Drawing.Point(130, 237);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(96, 20);
            this.txtFechaIngreso.TabIndex = 126;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(66, 235);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 20);
            this.label25.TabIndex = 125;
            this.label25.Text = "Fecha:";
            // 
            // txtfechaNacimiento
            // 
            this.txtfechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfechaNacimiento.Location = new System.Drawing.Point(434, 173);
            this.txtfechaNacimiento.Name = "txtfechaNacimiento";
            this.txtfechaNacimiento.Size = new System.Drawing.Size(98, 20);
            this.txtfechaNacimiento.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 121;
            this.label2.Text = "Codigo:";
            // 
            // txtCodEmpleado
            // 
            this.txtCodEmpleado.Location = new System.Drawing.Point(140, 35);
            this.txtCodEmpleado.Name = "txtCodEmpleado";
            this.txtCodEmpleado.ReadOnly = true;
            this.txtCodEmpleado.Size = new System.Drawing.Size(86, 20);
            this.txtCodEmpleado.TabIndex = 122;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(299, 237);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(116, 20);
            this.label.TabIndex = 119;
            this.label.Text = "Departamento:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(291, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 20);
            this.label17.TabIndex = 117;
            this.label17.Text = "Tipo Documento:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(363, 139);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 20);
            this.label18.TabIndex = 112;
            this.label18.Text = "Email:";
            // 
            // txtemailempleado
            // 
            this.txtemailempleado.Location = new System.Drawing.Point(434, 141);
            this.txtemailempleado.Name = "txtemailempleado";
            this.txtemailempleado.Size = new System.Drawing.Size(219, 20);
            this.txtemailempleado.TabIndex = 113;
            // 
            // txtdirecempleado
            // 
            this.txtdirecempleado.Location = new System.Drawing.Point(136, 147);
            this.txtdirecempleado.Multiline = true;
            this.txtdirecempleado.Name = "txtdirecempleado";
            this.txtdirecempleado.Size = new System.Drawing.Size(148, 64);
            this.txtdirecempleado.TabIndex = 106;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(340, 104);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 20);
            this.label19.TabIndex = 99;
            this.label19.Text = "Teléfono:";
            // 
            // txttelempleado
            // 
            this.txttelempleado.Location = new System.Drawing.Point(434, 106);
            this.txttelempleado.Name = "txttelempleado";
            this.txttelempleado.Size = new System.Drawing.Size(141, 20);
            this.txttelempleado.TabIndex = 100;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 20);
            this.txtNombre.TabIndex = 102;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(59, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 20);
            this.label20.TabIndex = 101;
            this.label20.Text = "Nombre:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(325, 168);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 20);
            this.label21.TabIndex = 107;
            this.label21.Text = "Fecha Nac:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(49, 147);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 20);
            this.label22.TabIndex = 103;
            this.label22.Text = "Dirección:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(59, 104);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 20);
            this.label23.TabIndex = 104;
            this.label23.Text = "Apellido:";
            // 
            // txtapeempleado
            // 
            this.txtapeempleado.Location = new System.Drawing.Point(137, 106);
            this.txtapeempleado.Name = "txtapeempleado";
            this.txtapeempleado.Size = new System.Drawing.Size(147, 20);
            this.txtapeempleado.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(226, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 25);
            this.label7.TabIndex = 98;
            this.label7.Text = "Registro de Empleado";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(46, 336);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 36);
            this.btnAgregar.TabIndex = 114;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(167, 336);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 36);
            this.btnModificar.TabIndex = 115;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(581, 336);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 36);
            this.btnSalir.TabIndex = 116;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabEmpleado
            // 
            this.tabEmpleado.Controls.Add(this.tabTipoProducto);
            this.tabEmpleado.Controls.Add(this.tabPage2);
            this.tabEmpleado.Location = new System.Drawing.Point(3, 96);
            this.tabEmpleado.Name = "tabEmpleado";
            this.tabEmpleado.SelectedIndex = 0;
            this.tabEmpleado.Size = new System.Drawing.Size(709, 408);
            this.tabEmpleado.TabIndex = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 79);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(176, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 37);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(663, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 36);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(247, 31);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 38);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(315, 31);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 38);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-2, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 92);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            // 
            // frmRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 515);
            this.Controls.Add(this.tabEmpleado);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRRHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entradamercancia";
            this.Load += new System.EventHandler(this.frmRRHH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleado)).EndInit();
            this.tabTipoProducto.ResumeLayout(false);
            this.tabTipoProducto.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabEmpleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button bnterrar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView tablaEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabTipoProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox txtTipoDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.ComboBox txtGenero;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker txtFechaIngreso;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker txtfechaNacimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodEmpleado;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtemailempleado;
        private System.Windows.Forms.TextBox txtdirecempleado;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txttelempleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtapeempleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TabControl tabEmpleado;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtDepartamento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}