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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvPasajes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAeropuertoDestino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAeropuertoOrigen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTipoPasaje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idPasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoPasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAeropuertoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeropuertoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAeropuertoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeropuertoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(537, 210);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 53;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(456, 210);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 52;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(590, 163);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 45;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(633, 476);
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
            this.idAeropuertoOrigen,
            this.aeropuertoOrigen,
            this.Origen,
            this.idAeropuertoDestino,
            this.aeropuertoDestino,
            this.Destino,
            this.Precio,
            this.Estado});
            this.dgvPasajes.Location = new System.Drawing.Point(11, 238);
            this.dgvPasajes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPasajes.MultiSelect = false;
            this.dgvPasajes.Name = "dgvPasajes";
            this.dgvPasajes.RowHeadersWidth = 51;
            this.dgvPasajes.RowTemplate.Height = 24;
            this.dgvPasajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasajes.Size = new System.Drawing.Size(697, 233);
            this.dgvPasajes.TabIndex = 71;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTipoPasaje);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbDestino);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbOrigen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbAeropuertoDestino);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbAeropuertoOrigen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 192);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros Pasaje";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbAeropuertoDestino
            // 
            this.cmbAeropuertoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAeropuertoDestino.FormattingEnabled = true;
            this.cmbAeropuertoDestino.Location = new System.Drawing.Point(552, 25);
            this.cmbAeropuertoDestino.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAeropuertoDestino.Name = "cmbAeropuertoDestino";
            this.cmbAeropuertoDestino.Size = new System.Drawing.Size(89, 21);
            this.cmbAeropuertoDestino.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Aeropuerto Destino:";
            // 
            // cmbAeropuertoOrigen
            // 
            this.cmbAeropuertoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAeropuertoOrigen.FormattingEnabled = true;
            this.cmbAeropuertoOrigen.Location = new System.Drawing.Point(359, 25);
            this.cmbAeropuertoOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAeropuertoOrigen.Name = "cmbAeropuertoOrigen";
            this.cmbAeropuertoOrigen.Size = new System.Drawing.Size(89, 21);
            this.cmbAeropuertoOrigen.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Aeropuerto Origen:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNroDocumento);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbTipoDocumento);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(22, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 91);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro Pasajero";
            // 
            // cmbTipoPasaje
            // 
            this.cmbTipoPasaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPasaje.FormattingEnabled = true;
            this.cmbTipoPasaje.Location = new System.Drawing.Point(103, 115);
            this.cmbTipoPasaje.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoPasaje.Name = "cmbTipoPasaje";
            this.cmbTipoPasaje.Size = new System.Drawing.Size(105, 21);
            this.cmbTipoPasaje.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tipo Pasaje:";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(113, 53);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(95, 20);
            this.txtNroDocumento.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "NroDocumetno:";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(113, 27);
            this.cmbTipoDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(95, 21);
            this.cmbTipoDocumento.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tipo Documento:";
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(552, 64);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(89, 21);
            this.cmbDestino.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Destino:";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(359, 64);
            this.cmbOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(89, 21);
            this.cmbOrigen.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Origen:";
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
            // idAeropuertoOrigen
            // 
            this.idAeropuertoOrigen.HeaderText = "IdAeropuertoOrigen";
            this.idAeropuertoOrigen.Name = "idAeropuertoOrigen";
            this.idAeropuertoOrigen.Visible = false;
            // 
            // aeropuertoOrigen
            // 
            this.aeropuertoOrigen.HeaderText = "Aeropuerto Origen";
            this.aeropuertoOrigen.MinimumWidth = 6;
            this.aeropuertoOrigen.Name = "aeropuertoOrigen";
            this.aeropuertoOrigen.ReadOnly = true;
            this.aeropuertoOrigen.Width = 125;
            // 
            // Origen
            // 
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            // 
            // idAeropuertoDestino
            // 
            this.idAeropuertoDestino.HeaderText = "IdAeropuertoDestino";
            this.idAeropuertoDestino.Name = "idAeropuertoDestino";
            this.idAeropuertoDestino.Visible = false;
            // 
            // aeropuertoDestino
            // 
            this.aeropuertoDestino.HeaderText = "Aeropuerto Destino";
            this.aeropuertoDestino.MinimumWidth = 6;
            this.aeropuertoDestino.Name = "aeropuertoDestino";
            this.aeropuertoDestino.ReadOnly = true;
            this.aeropuertoDestino.Width = 125;
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            this.Estado.Width = 125;
            // 
            // formPasajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPasajes);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "formPasajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasajes";
            this.Load += new System.EventHandler(this.formPasajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvPasajes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTipoPasaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAeropuertoOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAeropuertoDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPasaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoPasaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPasaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAeropuertoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeropuertoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAeropuertoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeropuertoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}