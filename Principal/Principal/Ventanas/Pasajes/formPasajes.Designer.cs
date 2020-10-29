namespace Principal.Ventanas
{
    partial class formPasajes
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvPasajes = new System.Windows.Forms.DataGridView();
            this.idPasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoPasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsignadoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Criticidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTipoPasaje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(604, 262);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 54;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(523, 262);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 53;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(442, 262);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 52;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(531, 181);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 45;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(632, 540);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 70;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvPasajes
            // 
            this.dgvPasajes.AllowUserToAddRows = false;
            this.dgvPasajes.AllowUserToDeleteRows = false;
            this.dgvPasajes.AllowUserToResizeRows = false;
            this.dgvPasajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPasaje,
            this.idTipoPasaje,
            this.tipoPasaje,
            this.tipoDocumento,
            this.nroDocumento,
            this.FechaCreacion,
            this.Estado,
            this.AsignadoA,
            this.Criticidad});
            this.dgvPasajes.Location = new System.Drawing.Point(25, 290);
            this.dgvPasajes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPasajes.MultiSelect = false;
            this.dgvPasajes.Name = "dgvPasajes";
            this.dgvPasajes.RowHeadersWidth = 51;
            this.dgvPasajes.RowTemplate.Height = 24;
            this.dgvPasajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasajes.Size = new System.Drawing.Size(667, 233);
            this.dgvPasajes.TabIndex = 71;
            // 
            // idPasaje
            // 
            this.idPasaje.HeaderText = "# Pasaje";
            this.idPasaje.MinimumWidth = 6;
            this.idPasaje.Name = "idPasaje";
            this.idPasaje.ReadOnly = true;
            this.idPasaje.Width = 125;
            // 
            // idTipoPasaje
            // 
            this.idTipoPasaje.HeaderText = "Id Tipo Pasaje";
            this.idTipoPasaje.Name = "idTipoPasaje";
            this.idTipoPasaje.Visible = false;
            // 
            // tipoPasaje
            // 
            this.tipoPasaje.HeaderText = "Tipo Pasaje";
            this.tipoPasaje.MinimumWidth = 6;
            this.tipoPasaje.Name = "tipoPasaje";
            this.tipoPasaje.ReadOnly = true;
            this.tipoPasaje.Width = 125;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.HeaderText = "Tipo Documento";
            this.tipoDocumento.MinimumWidth = 6;
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.ReadOnly = true;
            this.tipoDocumento.Width = 125;
            // 
            // nroDocumento
            // 
            this.nroDocumento.HeaderText = "Nro Documento";
            this.nroDocumento.MinimumWidth = 6;
            this.nroDocumento.Name = "nroDocumento";
            this.nroDocumento.ReadOnly = true;
            this.nroDocumento.Width = 125;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.HeaderText = "Fecha de creacion";
            this.FechaCreacion.MinimumWidth = 6;
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            this.FechaCreacion.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // AsignadoA
            // 
            this.AsignadoA.HeaderText = "Asignado a";
            this.AsignadoA.MinimumWidth = 6;
            this.AsignadoA.Name = "AsignadoA";
            this.AsignadoA.ReadOnly = true;
            this.AsignadoA.Width = 125;
            // 
            // Criticidad
            // 
            this.Criticidad.HeaderText = "Criticidad";
            this.Criticidad.MinimumWidth = 6;
            this.Criticidad.Name = "Criticidad";
            this.Criticidad.ReadOnly = true;
            this.Criticidad.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 210);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros Pasajes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTipoPasaje);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNroDocumento);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbTipoDocumento);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(22, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 91);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros Pasajeros";
            // 
            // cmbTipoPasaje
            // 
            this.cmbTipoPasaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPasaje.FormattingEnabled = true;
            this.cmbTipoPasaje.Location = new System.Drawing.Point(295, 27);
            this.cmbTipoPasaje.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoPasaje.Name = "cmbTipoPasaje";
            this.cmbTipoPasaje.Size = new System.Drawing.Size(117, 21);
            this.cmbTipoPasaje.TabIndex = 41;
            this.cmbTipoPasaje.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPasaje_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tipo Pasaje:";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(104, 55);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(82, 20);
            this.txtNroDocumento.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "NroDocumetno:";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(104, 29);
            this.cmbTipoDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(117, 21);
            this.cmbTipoDocumento.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tipo Documento:";
            // 
            // formPasajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPasajes);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "formPasajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasajes";
            this.Load += new System.EventHandler(this.formPasajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvPasajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPasaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoPasaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPasaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsignadoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Criticidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTipoPasaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label3;
    }
}