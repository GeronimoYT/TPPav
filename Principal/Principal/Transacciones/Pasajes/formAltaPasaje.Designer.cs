namespace Principal.Ventanas
{
    partial class formAltaPasaje
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.group_box = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvVuelos = new System.Windows.Forms.DataGridView();
            this.dtpFechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.cmbAeropuertoDestino = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAeropuertoOrigen = new System.Windows.Forms.ComboBox();
            this.cmbTipoPasaje = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNroDocumento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.txtApellidoPasajero = new System.Windows.Forms.TextBox();
            this.txtNombrePasajero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDecripcion = new System.Windows.Forms.TextBox();
            this.NroVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAeropuertoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AeropuertoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAeropuertoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AeropuertoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracionMinutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_box.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Location = new System.Drawing.Point(484, 523);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(565, 523);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // group_box
            // 
            this.group_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_box.Controls.Add(this.txtDecripcion);
            this.group_box.Controls.Add(this.groupBox2);
            this.group_box.Controls.Add(this.cmbTipoPasaje);
            this.group_box.Controls.Add(this.groupBox1);
            this.group_box.Controls.Add(this.label7);
            this.group_box.Controls.Add(this.label6);
            this.group_box.Location = new System.Drawing.Point(12, 12);
            this.group_box.Name = "group_box";
            this.group_box.Size = new System.Drawing.Size(628, 505);
            this.group_box.TabIndex = 90;
            this.group_box.TabStop = false;
            this.group_box.Text = "Pasaje";
            this.group_box.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dgvVuelos);
            this.groupBox2.Controls.Add(this.dtpFechaLlegada);
            this.groupBox2.Controls.Add(this.dtpFechaSalida);
            this.groupBox2.Controls.Add(this.cmbAeropuertoDestino);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbAeropuertoOrigen);
            this.groupBox2.Location = new System.Drawing.Point(6, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 248);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro Vuelos";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(535, 53);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 107;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 114;
            this.label10.Text = "Fecha Llegada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 113;
            this.label8.Text = "Fecha Salida:";
            // 
            // dgvVuelos
            // 
            this.dgvVuelos.AllowUserToAddRows = false;
            this.dgvVuelos.AllowUserToDeleteRows = false;
            this.dgvVuelos.AllowUserToResizeRows = false;
            this.dgvVuelos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroVuelo,
            this.IdAeropuertoOrigen,
            this.AeropuertoOrigen,
            this.origen,
            this.IdAeropuertoDestino,
            this.AeropuertoDestino,
            this.destino,
            this.FechaHoraSalida,
            this.FechaHoraLlegada,
            this.DuracionMinutos,
            this.NroAvion,
            this.IdTipoAvion,
            this.TipoAvion,
            this.Estado});
            this.dgvVuelos.Location = new System.Drawing.Point(7, 80);
            this.dgvVuelos.MultiSelect = false;
            this.dgvVuelos.Name = "dgvVuelos";
            this.dgvVuelos.ReadOnly = true;
            this.dgvVuelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVuelos.Size = new System.Drawing.Size(603, 162);
            this.dgvVuelos.TabIndex = 112;
            // 
            // dtpFechaLlegada
            // 
            this.dtpFechaLlegada.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaLlegada.Location = new System.Drawing.Point(363, 47);
            this.dtpFechaLlegada.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpFechaLlegada.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpFechaLlegada.Name = "dtpFechaLlegada";
            this.dtpFechaLlegada.Size = new System.Drawing.Size(114, 20);
            this.dtpFechaLlegada.TabIndex = 111;
            this.dtpFechaLlegada.TabStop = false;
            this.dtpFechaLlegada.Value = new System.DateTime(2020, 10, 28, 17, 38, 32, 0);
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaSalida.Location = new System.Drawing.Point(104, 46);
            this.dtpFechaSalida.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpFechaSalida.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(114, 20);
            this.dtpFechaSalida.TabIndex = 110;
            this.dtpFechaSalida.TabStop = false;
            this.dtpFechaSalida.Value = new System.DateTime(2020, 10, 28, 0, 0, 0, 0);
            this.dtpFechaSalida.ValueChanged += new System.EventHandler(this.dtpFechaSalida_ValueChanged);
            // 
            // cmbAeropuertoDestino
            // 
            this.cmbAeropuertoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAeropuertoDestino.FormattingEnabled = true;
            this.cmbAeropuertoDestino.Location = new System.Drawing.Point(363, 19);
            this.cmbAeropuertoDestino.Name = "cmbAeropuertoDestino";
            this.cmbAeropuertoDestino.Size = new System.Drawing.Size(105, 21);
            this.cmbAeropuertoDestino.TabIndex = 109;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 108;
            this.label9.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 107;
            this.label3.Text = "Origen:";
            // 
            // cmbAeropuertoOrigen
            // 
            this.cmbAeropuertoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAeropuertoOrigen.FormattingEnabled = true;
            this.cmbAeropuertoOrigen.Location = new System.Drawing.Point(106, 17);
            this.cmbAeropuertoOrigen.Name = "cmbAeropuertoOrigen";
            this.cmbAeropuertoOrigen.Size = new System.Drawing.Size(112, 21);
            this.cmbAeropuertoOrigen.TabIndex = 106;
            // 
            // cmbTipoPasaje
            // 
            this.cmbTipoPasaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPasaje.FormattingEnabled = true;
            this.cmbTipoPasaje.Location = new System.Drawing.Point(110, 135);
            this.cmbTipoPasaje.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoPasaje.Name = "cmbTipoPasaje";
            this.cmbTipoPasaje.Size = new System.Drawing.Size(112, 21);
            this.cmbTipoPasaje.TabIndex = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbNroDocumento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTipoDocumento);
            this.groupBox1.Controls.Add(this.btnDetalle);
            this.groupBox1.Controls.Add(this.txtApellidoPasajero);
            this.groupBox1.Controls.Add(this.txtNombrePasajero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(66, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 111);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pasajero";
            // 
            // cmbNroDocumento
            // 
            this.cmbNroDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNroDocumento.FormattingEnabled = true;
            this.cmbNroDocumento.Location = new System.Drawing.Point(318, 19);
            this.cmbNroDocumento.Name = "cmbNroDocumento";
            this.cmbNroDocumento.Size = new System.Drawing.Size(121, 21);
            this.cmbNroDocumento.TabIndex = 68;
            this.cmbNroDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbNroDocumento_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Nro Documento(*):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Tipo Documento(*):";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(115, 19);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(105, 21);
            this.cmbTipoDocumento.TabIndex = 65;
            this.cmbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDocumento_SelectedIndexChanged);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(388, 82);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 64;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // txtApellidoPasajero
            // 
            this.txtApellidoPasajero.Enabled = false;
            this.txtApellidoPasajero.Location = new System.Drawing.Point(70, 48);
            this.txtApellidoPasajero.Name = "txtApellidoPasajero";
            this.txtApellidoPasajero.ReadOnly = true;
            this.txtApellidoPasajero.Size = new System.Drawing.Size(150, 20);
            this.txtApellidoPasajero.TabIndex = 51;
            // 
            // txtNombrePasajero
            // 
            this.txtNombrePasajero.Enabled = false;
            this.txtNombrePasajero.Location = new System.Drawing.Point(290, 48);
            this.txtNombrePasajero.Name = "txtNombrePasajero";
            this.txtNombrePasajero.ReadOnly = true;
            this.txtNombrePasajero.Size = new System.Drawing.Size(149, 20);
            this.txtNombrePasajero.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Motivo de Viaje:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 90;
            this.label6.Text = "Clase(*):";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtDecripcion
            // 
            this.txtDecripcion.Location = new System.Drawing.Point(151, 423);
            this.txtDecripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDecripcion.MaxLength = 50;
            this.txtDecripcion.Multiline = true;
            this.txtDecripcion.Name = "txtDecripcion";
            this.txtDecripcion.Size = new System.Drawing.Size(323, 67);
            this.txtDecripcion.TabIndex = 115;
            // 
            // NroVuelo
            // 
            this.NroVuelo.DataPropertyName = "NroVuelo";
            this.NroVuelo.HeaderText = "NroVuelo";
            this.NroVuelo.Name = "NroVuelo";
            this.NroVuelo.ReadOnly = true;
            this.NroVuelo.Width = 75;
            // 
            // IdAeropuertoOrigen
            // 
            this.IdAeropuertoOrigen.HeaderText = "IdAeropuertoOrigen";
            this.IdAeropuertoOrigen.Name = "IdAeropuertoOrigen";
            this.IdAeropuertoOrigen.ReadOnly = true;
            this.IdAeropuertoOrigen.Visible = false;
            // 
            // AeropuertoOrigen
            // 
            this.AeropuertoOrigen.DataPropertyName = "IdAeropuerto";
            this.AeropuertoOrigen.HeaderText = "AeropuertoOrigen";
            this.AeropuertoOrigen.Name = "AeropuertoOrigen";
            this.AeropuertoOrigen.ReadOnly = true;
            // 
            // origen
            // 
            this.origen.HeaderText = "Origen";
            this.origen.Name = "origen";
            this.origen.ReadOnly = true;
            // 
            // IdAeropuertoDestino
            // 
            this.IdAeropuertoDestino.HeaderText = "IdAeropuertoDestino";
            this.IdAeropuertoDestino.Name = "IdAeropuertoDestino";
            this.IdAeropuertoDestino.ReadOnly = true;
            this.IdAeropuertoDestino.Visible = false;
            // 
            // AeropuertoDestino
            // 
            this.AeropuertoDestino.DataPropertyName = "IdAeropuertoDestino";
            this.AeropuertoDestino.HeaderText = "AeropuertoDestino";
            this.AeropuertoDestino.Name = "AeropuertoDestino";
            this.AeropuertoDestino.ReadOnly = true;
            this.AeropuertoDestino.Width = 120;
            // 
            // destino
            // 
            this.destino.HeaderText = "Destino";
            this.destino.Name = "destino";
            this.destino.ReadOnly = true;
            // 
            // FechaHoraSalida
            // 
            this.FechaHoraSalida.DataPropertyName = "FechaHoraSalida";
            this.FechaHoraSalida.HeaderText = "FechaHoraSalida";
            this.FechaHoraSalida.Name = "FechaHoraSalida";
            this.FechaHoraSalida.ReadOnly = true;
            this.FechaHoraSalida.Width = 120;
            // 
            // FechaHoraLlegada
            // 
            this.FechaHoraLlegada.DataPropertyName = "FechaHoraLlegada";
            this.FechaHoraLlegada.HeaderText = "FechaHoraLlegada";
            this.FechaHoraLlegada.Name = "FechaHoraLlegada";
            this.FechaHoraLlegada.ReadOnly = true;
            this.FechaHoraLlegada.Width = 120;
            // 
            // DuracionMinutos
            // 
            this.DuracionMinutos.HeaderText = "DuracionMinutos";
            this.DuracionMinutos.Name = "DuracionMinutos";
            this.DuracionMinutos.ReadOnly = true;
            // 
            // NroAvion
            // 
            this.NroAvion.DataPropertyName = "NroAvion";
            this.NroAvion.HeaderText = "NroAvion";
            this.NroAvion.Name = "NroAvion";
            this.NroAvion.ReadOnly = true;
            this.NroAvion.Visible = false;
            this.NroAvion.Width = 70;
            // 
            // IdTipoAvion
            // 
            this.IdTipoAvion.DataPropertyName = "IdTipoAvion";
            this.IdTipoAvion.HeaderText = "idTipoAvion";
            this.IdTipoAvion.Name = "IdTipoAvion";
            this.IdTipoAvion.ReadOnly = true;
            this.IdTipoAvion.Visible = false;
            this.IdTipoAvion.Width = 80;
            // 
            // TipoAvion
            // 
            this.TipoAvion.HeaderText = "TipoAvion";
            this.TipoAvion.Name = "TipoAvion";
            this.TipoAvion.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            this.Estado.Width = 70;
            // 
            // formAltaPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 558);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.group_box);
            this.Controls.Add(this.btnCancelar);
            this.Name = "formAltaPasaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Pasaje";
            this.Load += new System.EventHandler(this.formAltaPasaje_Load);
            this.group_box.ResumeLayout(false);
            this.group_box.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox group_box;
        private System.Windows.Forms.ComboBox cmbTipoPasaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNroDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.TextBox txtApellidoPasajero;
        private System.Windows.Forms.TextBox txtNombrePasajero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvVuelos;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegada;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.ComboBox cmbAeropuertoDestino;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAeropuertoOrigen;
        private System.Windows.Forms.TextBox txtDecripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAeropuertoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn AeropuertoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAeropuertoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn AeropuertoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracionMinutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}