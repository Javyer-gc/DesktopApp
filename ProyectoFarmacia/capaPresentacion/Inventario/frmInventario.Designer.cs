namespace capaPresentacion.Inventario
{
    partial class frmInventario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDMEDICAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCATEGORIAMEDICAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREMEDICAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mILIGRAMOSMILILITROSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPUESTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONMEDICAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADPORHABERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tABLAMEDICAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProyecto = new capaPresentacion.dsProyecto();
            this.tABLA_MEDICAMENTOTableAdapter = new capaPresentacion.dsProyectoTableAdapters.TABLA_MEDICAMENTOTableAdapter();
            this.tABLAMEDICAMENTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLAMEDICAMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProyecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLAMEDICAMENTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 39);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1148, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMEDICAMENTODataGridViewTextBoxColumn,
            this.iDCATEGORIAMEDICAMENTODataGridViewTextBoxColumn,
            this.nOMBREMEDICAMENTODataGridViewTextBoxColumn,
            this.mILIGRAMOSMILILITROSDataGridViewTextBoxColumn,
            this.cOMPUESTODataGridViewTextBoxColumn,
            this.dESCRIPCIONMEDICAMENTODataGridViewTextBoxColumn,
            this.cANTIDADPORHABERDataGridViewTextBoxColumn,
            this.cANTIDADSTOCKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tABLAMEDICAMENTOBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 46);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 561);
            this.dataGridView1.TabIndex = 10;
            // 
            // iDMEDICAMENTODataGridViewTextBoxColumn
            // 
            this.iDMEDICAMENTODataGridViewTextBoxColumn.DataPropertyName = "ID_MEDICAMENTO";
            this.iDMEDICAMENTODataGridViewTextBoxColumn.HeaderText = "ID_MEDICAMENTO";
            this.iDMEDICAMENTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDMEDICAMENTODataGridViewTextBoxColumn.Name = "iDMEDICAMENTODataGridViewTextBoxColumn";
            this.iDMEDICAMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDMEDICAMENTODataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCATEGORIAMEDICAMENTODataGridViewTextBoxColumn
            // 
            this.iDCATEGORIAMEDICAMENTODataGridViewTextBoxColumn.DataPropertyName = "ID_CATEGORIA_MEDICAMENTO";
            this.iDCATEGORIAMEDICAMENTODataGridViewTextBoxColumn.HeaderText = "ID_CATEGORIA_MEDICAMENTO";
            this.iDCATEGORIAMEDICAMENTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCATEGORIAMEDICAMENTODataGridViewTextBoxColumn.Name = "iDCATEGORIAMEDICAMENTODataGridViewTextBoxColumn";
            this.iDCATEGORIAMEDICAMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCATEGORIAMEDICAMENTODataGridViewTextBoxColumn.Width = 125;
            // 
            // nOMBREMEDICAMENTODataGridViewTextBoxColumn
            // 
            this.nOMBREMEDICAMENTODataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_MEDICAMENTO";
            this.nOMBREMEDICAMENTODataGridViewTextBoxColumn.HeaderText = "NOMBRE_MEDICAMENTO";
            this.nOMBREMEDICAMENTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOMBREMEDICAMENTODataGridViewTextBoxColumn.Name = "nOMBREMEDICAMENTODataGridViewTextBoxColumn";
            this.nOMBREMEDICAMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMBREMEDICAMENTODataGridViewTextBoxColumn.Width = 125;
            // 
            // mILIGRAMOSMILILITROSDataGridViewTextBoxColumn
            // 
            this.mILIGRAMOSMILILITROSDataGridViewTextBoxColumn.DataPropertyName = "MILIGRAMOS_MILILITROS";
            this.mILIGRAMOSMILILITROSDataGridViewTextBoxColumn.HeaderText = "MILIGRAMOS_MILILITROS";
            this.mILIGRAMOSMILILITROSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mILIGRAMOSMILILITROSDataGridViewTextBoxColumn.Name = "mILIGRAMOSMILILITROSDataGridViewTextBoxColumn";
            this.mILIGRAMOSMILILITROSDataGridViewTextBoxColumn.ReadOnly = true;
            this.mILIGRAMOSMILILITROSDataGridViewTextBoxColumn.Width = 125;
            // 
            // cOMPUESTODataGridViewTextBoxColumn
            // 
            this.cOMPUESTODataGridViewTextBoxColumn.DataPropertyName = "COMPUESTO";
            this.cOMPUESTODataGridViewTextBoxColumn.HeaderText = "COMPUESTO";
            this.cOMPUESTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cOMPUESTODataGridViewTextBoxColumn.Name = "cOMPUESTODataGridViewTextBoxColumn";
            this.cOMPUESTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMPUESTODataGridViewTextBoxColumn.Width = 125;
            // 
            // dESCRIPCIONMEDICAMENTODataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONMEDICAMENTODataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION_MEDICAMENTO";
            this.dESCRIPCIONMEDICAMENTODataGridViewTextBoxColumn.HeaderText = "DESCRIPCION_MEDICAMENTO";
            this.dESCRIPCIONMEDICAMENTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dESCRIPCIONMEDICAMENTODataGridViewTextBoxColumn.Name = "dESCRIPCIONMEDICAMENTODataGridViewTextBoxColumn";
            this.dESCRIPCIONMEDICAMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRIPCIONMEDICAMENTODataGridViewTextBoxColumn.Width = 125;
            // 
            // cANTIDADPORHABERDataGridViewTextBoxColumn
            // 
            this.cANTIDADPORHABERDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD_POR_HABER";
            this.cANTIDADPORHABERDataGridViewTextBoxColumn.HeaderText = "CANTIDAD_POR_HABER";
            this.cANTIDADPORHABERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cANTIDADPORHABERDataGridViewTextBoxColumn.Name = "cANTIDADPORHABERDataGridViewTextBoxColumn";
            this.cANTIDADPORHABERDataGridViewTextBoxColumn.ReadOnly = true;
            this.cANTIDADPORHABERDataGridViewTextBoxColumn.Width = 125;
            // 
            // cANTIDADSTOCKDataGridViewTextBoxColumn
            // 
            this.cANTIDADSTOCKDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD_STOCK";
            this.cANTIDADSTOCKDataGridViewTextBoxColumn.HeaderText = "CANTIDAD_STOCK";
            this.cANTIDADSTOCKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cANTIDADSTOCKDataGridViewTextBoxColumn.Name = "cANTIDADSTOCKDataGridViewTextBoxColumn";
            this.cANTIDADSTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            this.cANTIDADSTOCKDataGridViewTextBoxColumn.Width = 125;
            // 
            // tABLAMEDICAMENTOBindingSource
            // 
            this.tABLAMEDICAMENTOBindingSource.DataMember = "TABLA_MEDICAMENTO";
            this.tABLAMEDICAMENTOBindingSource.DataSource = this.dsProyecto;
            // 
            // dsProyecto
            // 
            this.dsProyecto.DataSetName = "dsProyecto";
            this.dsProyecto.EnforceConstraints = false;
            this.dsProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tABLA_MEDICAMENTOTableAdapter
            // 
            this.tABLA_MEDICAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // tABLAMEDICAMENTOBindingSource1
            // 
            this.tABLAMEDICAMENTOBindingSource1.DataMember = "TABLA_MEDICAMENTO";
            this.tABLAMEDICAMENTOBindingSource1.DataSource = this.dsProyecto;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 738);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1200, 738);
            this.MinimumSize = new System.Drawing.Size(1200, 738);
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLAMEDICAMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProyecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLAMEDICAMENTOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsProyecto dsProyecto;
        private System.Windows.Forms.BindingSource tABLAMEDICAMENTOBindingSource;
        private dsProyectoTableAdapters.TABLA_MEDICAMENTOTableAdapter tABLA_MEDICAMENTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMEDICAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCATEGORIAMEDICAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREMEDICAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mILIGRAMOSMILILITROSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPUESTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONMEDICAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADPORHABERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tABLAMEDICAMENTOBindingSource1;
    }
}