namespace capaPresentacion.Ajustes
{
    partial class frmEmpleados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsEmpleados = new System.Windows.Forms.ToolStrip();
            this.toolStripAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripRegresar = new System.Windows.Forms.ToolStripButton();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gbBusquedas = new System.Windows.Forms.GroupBox();
            this.txtBAMaterno = new System.Windows.Forms.TextBox();
            this.lblAMaterno = new System.Windows.Forms.Label();
            this.txtBAPaterno = new System.Windows.Forms.TextBox();
            this.lblAPaterno = new System.Windows.Forms.Label();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtVPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAMaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAPaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTIPOUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSWORDUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATATABLEUSUARIOBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dsProyecto = new capaPresentacion.dsProyecto();
            this.dATATABLEUSUARIOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.DATATABLEUSUARIOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DATATABLEUSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DATATABLE_USUARIOTableAdapter = new capaPresentacion.dsProyectoTableAdapters.DATATABLE_USUARIOTableAdapter();
            this.tableAdapterManager1 = new capaPresentacion.dsProyectoTableAdapters.TableAdapterManager();
            this.datatablE_USUARIOTableAdapter1 = new capaPresentacion.dsProyectoTableAdapters.DATATABLE_USUARIOTableAdapter();
            this.dsProyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbBusquedas.SuspendLayout();
            this.gbUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATATABLEUSUARIOBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProyecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATATABLEUSUARIOBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATATABLEUSUARIOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATATABLEUSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProyectoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tsEmpleados
            // 
            this.tsEmpleados.AutoSize = false;
            this.tsEmpleados.BackColor = System.Drawing.Color.White;
            this.tsEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsEmpleados.Dock = System.Windows.Forms.DockStyle.None;
            this.tsEmpleados.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsEmpleados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAgregar,
            this.toolStripModificar,
            this.toolStripBorrar,
            this.toolStripSeparator1,
            this.toolStripCancelar,
            this.toolStripGuardar,
            this.toolStripSeparator2,
            this.toolStripRegresar});
            this.tsEmpleados.Location = new System.Drawing.Point(0, 29);
            this.tsEmpleados.Name = "tsEmpleados";
            this.tsEmpleados.Size = new System.Drawing.Size(809, 95);
            this.tsEmpleados.TabIndex = 0;
            this.tsEmpleados.Text = "toolStrip1";
            this.tsEmpleados.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsEmpleados_ItemClicked);
            // 
            // toolStripAgregar
            // 
            this.toolStripAgregar.ForeColor = System.Drawing.Color.Black;
            this.toolStripAgregar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAgregar.Image")));
            this.toolStripAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAgregar.Name = "toolStripAgregar";
            this.toolStripAgregar.Size = new System.Drawing.Size(67, 92);
            this.toolStripAgregar.Text = "&Agregar";
            this.toolStripAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripAgregar.Click += new System.EventHandler(this.toolStripAgregar_Click);
            // 
            // toolStripModificar
            // 
            this.toolStripModificar.ForeColor = System.Drawing.Color.Black;
            this.toolStripModificar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripModificar.Image")));
            this.toolStripModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripModificar.Name = "toolStripModificar";
            this.toolStripModificar.Size = new System.Drawing.Size(77, 92);
            this.toolStripModificar.Text = "&Modificar";
            this.toolStripModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripModificar.Click += new System.EventHandler(this.toolStripModificar_Click);
            // 
            // toolStripBorrar
            // 
            this.toolStripBorrar.ForeColor = System.Drawing.Color.Black;
            this.toolStripBorrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBorrar.Image")));
            this.toolStripBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBorrar.Name = "toolStripBorrar";
            this.toolStripBorrar.Size = new System.Drawing.Size(54, 92);
            this.toolStripBorrar.Text = "&Borrar";
            this.toolStripBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBorrar.Click += new System.EventHandler(this.toolStripBorrar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 95);
            // 
            // toolStripCancelar
            // 
            this.toolStripCancelar.ForeColor = System.Drawing.Color.Black;
            this.toolStripCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCancelar.Image")));
            this.toolStripCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCancelar.Name = "toolStripCancelar";
            this.toolStripCancelar.Size = new System.Drawing.Size(70, 92);
            this.toolStripCancelar.Text = "&Cancelar";
            this.toolStripCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripCancelar.Click += new System.EventHandler(this.toolStripCancelar_Click);
            // 
            // toolStripGuardar
            // 
            this.toolStripGuardar.ForeColor = System.Drawing.Color.Black;
            this.toolStripGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGuardar.Image")));
            this.toolStripGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGuardar.Name = "toolStripGuardar";
            this.toolStripGuardar.Size = new System.Drawing.Size(66, 92);
            this.toolStripGuardar.Text = "&Guardar";
            this.toolStripGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripGuardar.Click += new System.EventHandler(this.toolStripGuardar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 95);
            // 
            // toolStripRegresar
            // 
            this.toolStripRegresar.ForeColor = System.Drawing.Color.Black;
            this.toolStripRegresar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRegresar.Image")));
            this.toolStripRegresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRegresar.Name = "toolStripRegresar";
            this.toolStripRegresar.Size = new System.Drawing.Size(71, 92);
            this.toolStripRegresar.Text = "&Regresar";
            this.toolStripRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripRegresar.Click += new System.EventHandler(this.toolStripRegresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tsEmpleados);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 85);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(748, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(-5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "Gestión de usuarios";
            // 
            // gbBusquedas
            // 
            this.gbBusquedas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbBusquedas.Controls.Add(this.txtBAMaterno);
            this.gbBusquedas.Controls.Add(this.lblAMaterno);
            this.gbBusquedas.Controls.Add(this.txtBAPaterno);
            this.gbBusquedas.Controls.Add(this.lblAPaterno);
            this.gbBusquedas.Controls.Add(this.txtBNombre);
            this.gbBusquedas.Controls.Add(this.lblNombre);
            this.gbBusquedas.Location = new System.Drawing.Point(12, 327);
            this.gbBusquedas.Name = "gbBusquedas";
            this.gbBusquedas.Size = new System.Drawing.Size(240, 368);
            this.gbBusquedas.TabIndex = 3;
            this.gbBusquedas.TabStop = false;
            this.gbBusquedas.Text = "Búsquedas";
            this.gbBusquedas.Enter += new System.EventHandler(this.gbBusquedas_Enter);
            // 
            // txtBAMaterno
            // 
            this.txtBAMaterno.Location = new System.Drawing.Point(6, 285);
            this.txtBAMaterno.Name = "txtBAMaterno";
            this.txtBAMaterno.Size = new System.Drawing.Size(221, 30);
            this.txtBAMaterno.TabIndex = 5;
            this.txtBAMaterno.TextChanged += new System.EventHandler(this.txtBAMaterno_TextChanged);
            // 
            // lblAMaterno
            // 
            this.lblAMaterno.AutoSize = true;
            this.lblAMaterno.ForeColor = System.Drawing.Color.Black;
            this.lblAMaterno.Location = new System.Drawing.Point(5, 257);
            this.lblAMaterno.Name = "lblAMaterno";
            this.lblAMaterno.Size = new System.Drawing.Size(114, 25);
            this.lblAMaterno.TabIndex = 4;
            this.lblAMaterno.Text = "A. Materno:";
            // 
            // txtBAPaterno
            // 
            this.txtBAPaterno.Location = new System.Drawing.Point(6, 197);
            this.txtBAPaterno.Name = "txtBAPaterno";
            this.txtBAPaterno.Size = new System.Drawing.Size(221, 30);
            this.txtBAPaterno.TabIndex = 3;
            this.txtBAPaterno.TextChanged += new System.EventHandler(this.txtBAPaterno_TextChanged);
            // 
            // lblAPaterno
            // 
            this.lblAPaterno.AutoSize = true;
            this.lblAPaterno.ForeColor = System.Drawing.Color.Black;
            this.lblAPaterno.Location = new System.Drawing.Point(5, 169);
            this.lblAPaterno.Name = "lblAPaterno";
            this.lblAPaterno.Size = new System.Drawing.Size(110, 25);
            this.lblAPaterno.TabIndex = 2;
            this.lblAPaterno.Text = "A. Paterno:";
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(6, 107);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(221, 30);
            this.txtBNombre.TabIndex = 1;
            this.txtBNombre.TextChanged += new System.EventHandler(this.txtBNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(5, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // gbUsuarios
            // 
            this.gbUsuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbUsuarios.Controls.Add(this.cmbPuesto);
            this.gbUsuarios.Controls.Add(this.lblPuesto);
            this.gbUsuarios.Controls.Add(this.txtVPassword);
            this.gbUsuarios.Controls.Add(this.label6);
            this.gbUsuarios.Controls.Add(this.txtPassword);
            this.gbUsuarios.Controls.Add(this.label5);
            this.gbUsuarios.Controls.Add(this.txtUsuario);
            this.gbUsuarios.Controls.Add(this.label4);
            this.gbUsuarios.Controls.Add(this.txtAMaterno);
            this.gbUsuarios.Controls.Add(this.label3);
            this.gbUsuarios.Controls.Add(this.txtAPaterno);
            this.gbUsuarios.Controls.Add(this.label2);
            this.gbUsuarios.Controls.Add(this.txtNombre);
            this.gbUsuarios.Controls.Add(this.label1);
            this.gbUsuarios.Location = new System.Drawing.Point(258, 327);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Size = new System.Drawing.Size(530, 368);
            this.gbUsuarios.TabIndex = 4;
            this.gbUsuarios.TabStop = false;
            this.gbUsuarios.Text = "Datos Usuario";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Items.AddRange(new object[] {
            "Empleado",
            "Administrador"});
            this.cmbPuesto.Location = new System.Drawing.Point(148, 321);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(376, 33);
            this.cmbPuesto.TabIndex = 15;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.ForeColor = System.Drawing.Color.Black;
            this.lblPuesto.Location = new System.Drawing.Point(63, 324);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(79, 25);
            this.lblPuesto.TabIndex = 14;
            this.lblPuesto.Text = "Puesto:";
            // 
            // txtVPassword
            // 
            this.txtVPassword.Location = new System.Drawing.Point(148, 272);
            this.txtVPassword.Name = "txtVPassword";
            this.txtVPassword.Size = new System.Drawing.Size(376, 30);
            this.txtVPassword.TabIndex = 13;
            this.txtVPassword.UseSystemPasswordChar = true;
            this.txtVPassword.TextChanged += new System.EventHandler(this.txtVPassword_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "V. Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(148, 227);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(376, 30);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(148, 178);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(376, 30);
            this.txtUsuario.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(63, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Usuario:";
            // 
            // txtAMaterno
            // 
            this.txtAMaterno.Location = new System.Drawing.Point(148, 132);
            this.txtAMaterno.Name = "txtAMaterno";
            this.txtAMaterno.Size = new System.Drawing.Size(376, 30);
            this.txtAMaterno.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "A. Materno:";
            // 
            // txtAPaterno
            // 
            this.txtAPaterno.Location = new System.Drawing.Point(148, 86);
            this.txtAPaterno.Name = "txtAPaterno";
            this.txtAPaterno.Size = new System.Drawing.Size(376, 30);
            this.txtAPaterno.TabIndex = 5;
            this.txtAPaterno.TextChanged += new System.EventHandler(this.txtAPaterno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "A. Paterno:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(148, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(376, 30);
            this.txtNombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(63, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.AllowUserToAddRows = false;
            this.dgUsuarios.AllowUserToDeleteRows = false;
            this.dgUsuarios.AutoGenerateColumns = false;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.iDTIPOUSUARIODataGridViewTextBoxColumn,
            this.uSERUSUARIODataGridViewTextBoxColumn,
            this.pASSWORDUSUARIODataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgUsuarios.DataSource = this.dATATABLEUSUARIOBindingSource3;
            this.dgUsuarios.Location = new System.Drawing.Point(8, 91);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.ReadOnly = true;
            this.dgUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUsuarios.RowTemplate.Height = 24;
            this.dgUsuarios.Size = new System.Drawing.Size(780, 230);
            this.dgUsuarios.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_USUARIO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID USUARIO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // iDTIPOUSUARIODataGridViewTextBoxColumn
            // 
            this.iDTIPOUSUARIODataGridViewTextBoxColumn.DataPropertyName = "ID_TIPO_USUARIO";
            this.iDTIPOUSUARIODataGridViewTextBoxColumn.HeaderText = "TIPO DE USUARIO";
            this.iDTIPOUSUARIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDTIPOUSUARIODataGridViewTextBoxColumn.Name = "iDTIPOUSUARIODataGridViewTextBoxColumn";
            this.iDTIPOUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTIPOUSUARIODataGridViewTextBoxColumn.Width = 125;
            // 
            // uSERUSUARIODataGridViewTextBoxColumn
            // 
            this.uSERUSUARIODataGridViewTextBoxColumn.DataPropertyName = "USER_USUARIO";
            this.uSERUSUARIODataGridViewTextBoxColumn.HeaderText = "USUARIO";
            this.uSERUSUARIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uSERUSUARIODataGridViewTextBoxColumn.Name = "uSERUSUARIODataGridViewTextBoxColumn";
            this.uSERUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.uSERUSUARIODataGridViewTextBoxColumn.Width = 125;
            // 
            // pASSWORDUSUARIODataGridViewTextBoxColumn
            // 
            this.pASSWORDUSUARIODataGridViewTextBoxColumn.DataPropertyName = "PASSWORD_USUARIO";
            this.pASSWORDUSUARIODataGridViewTextBoxColumn.HeaderText = "PASSWORD_USUARIO";
            this.pASSWORDUSUARIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pASSWORDUSUARIODataGridViewTextBoxColumn.Name = "pASSWORDUSUARIODataGridViewTextBoxColumn";
            this.pASSWORDUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.pASSWORDUSUARIODataGridViewTextBoxColumn.Visible = false;
            this.pASSWORDUSUARIODataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE_U";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE USUARIO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "APELLIDO_P_U";
            this.dataGridViewTextBoxColumn3.HeaderText = "APELLIDO P. USUARIO";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "APELLIDO_M_U";
            this.dataGridViewTextBoxColumn4.HeaderText = "APELLIDO M. USUARIO";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dATATABLEUSUARIOBindingSource3
            // 
            this.dATATABLEUSUARIOBindingSource3.DataMember = "DATATABLE_USUARIO";
            this.dATATABLEUSUARIOBindingSource3.DataSource = this.dsProyecto;
            // 
            // dsProyecto
            // 
            this.dsProyecto.DataSetName = "dsProyecto";
            this.dsProyecto.EnforceConstraints = false;
            this.dsProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dATATABLEUSUARIOBindingSource2
            // 
            this.dATATABLEUSUARIOBindingSource2.DataMember = "DATATABLE_USUARIO";
            this.dATATABLEUSUARIOBindingSource2.DataSource = this.dsProyecto;
            // 
            // DATATABLEUSUARIOBindingSource1
            // 
            this.DATATABLEUSUARIOBindingSource1.DataMember = "DATATABLE_USUARIO";
            this.DATATABLEUSUARIOBindingSource1.DataSource = this.dsProyecto;
            // 
            // DATATABLEUSUARIOBindingSource
            // 
            this.DATATABLEUSUARIOBindingSource.DataMember = "DATATABLE_USUARIO";
            this.DATATABLEUSUARIOBindingSource.DataSource = this.dsProyecto;
            // 
            // DATATABLE_USUARIOTableAdapter
            // 
            this.DATATABLE_USUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.TABLA_MEDICAMENTOTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = capaPresentacion.dsProyectoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // datatablE_USUARIOTableAdapter1
            // 
            this.datatablE_USUARIOTableAdapter1.ClearBeforeFill = true;
            // 
            // dsProyectoBindingSource
            // 
            this.dsProyectoBindingSource.DataSource = this.dsProyecto;
            this.dsProyectoBindingSource.Position = 0;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.gbUsuarios);
            this.Controls.Add(this.gbBusquedas);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(800, 700);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Lista de Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.tsEmpleados.ResumeLayout(false);
            this.tsEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbBusquedas.ResumeLayout(false);
            this.gbBusquedas.PerformLayout();
            this.gbUsuarios.ResumeLayout(false);
            this.gbUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATATABLEUSUARIOBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProyecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATATABLEUSUARIOBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATATABLEUSUARIOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATATABLEUSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProyectoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsEmpleados;
        private System.Windows.Forms.ToolStripButton toolStripAgregar;
        private System.Windows.Forms.ToolStripButton toolStripRegresar;
        private System.Windows.Forms.ToolStripButton toolStripModificar;
        private System.Windows.Forms.ToolStripButton toolStripBorrar;
        private System.Windows.Forms.ToolStripButton toolStripGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbBusquedas;
        private System.Windows.Forms.TextBox txtBAMaterno;
        private System.Windows.Forms.Label lblAMaterno;
        private System.Windows.Forms.TextBox txtBAPaterno;
        private System.Windows.Forms.Label lblAPaterno;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbUsuarios;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAMaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAPaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDOPUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDOMUDataGridViewTextBoxColumn;
        private dsProyecto dsProyecto;
        private System.Windows.Forms.BindingSource DATATABLEUSUARIOBindingSource;
        private dsProyectoTableAdapters.DATATABLE_USUARIOTableAdapter DATATABLE_USUARIOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource DATATABLEUSUARIOBindingSource1;
        private dsProyectoTableAdapters.TableAdapterManager tableAdapterManager1;
        private dsProyectoTableAdapters.DATATABLE_USUARIOTableAdapter datatablE_USUARIOTableAdapter1;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aCTIVODataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource dATATABLEUSUARIOBindingSource2;
        private System.Windows.Forms.BindingSource dsProyectoBindingSource;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.BindingSource dATATABLEUSUARIOBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTIPOUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}