namespace Principal.Transacciones.Pasajes
{
    partial class formEditarPasaje
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvVuelos = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbAeropuertoDestino = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAeropuertoOrigen = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNroDocumento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.txtApellidoPasajero = new System.Windows.Forms.TextBox();
            this.txtNombrePasajero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNroPasaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoPasaje = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDecripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
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
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(610, 482);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(529, 482);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 56;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDecripcion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtNroPasaje);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbTipoPasaje);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 464);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pasaje";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dtpFechaLlegada);
            this.groupBox3.Controls.Add(this.dtpFechaSalida);
            this.groupBox3.Controls.Add(this.dgvVuelos);
            this.groupBox3.Controls.Add(this.btnConsultar);
            this.groupBox3.Controls.Add(this.cmbAeropuertoDestino);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbAeropuertoOrigen);
            this.groupBox3.Location = new System.Drawing.Point(14, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 214);
            this.groupBox3.TabIndex = 103;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros Vuelos";
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
            this.dgvVuelos.Location = new System.Drawing.Point(6, 74);
            this.dgvVuelos.MultiSelect = false;
            this.dgvVuelos.Name = "dgvVuelos";
            this.dgvVuelos.ReadOnly = true;
            this.dgvVuelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVuelos.Size = new System.Drawing.Size(628, 140);
            this.dgvVuelos.TabIndex = 113;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(559, 43);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 92;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cmbAeropuertoDestino
            // 
            this.cmbAeropuertoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAeropuertoDestino.FormattingEnabled = true;
            this.cmbAeropuertoDestino.Location = new System.Drawing.Point(384, 15);
            this.cmbAeropuertoDestino.Name = "cmbAeropuertoDestino";
            this.cmbAeropuertoDestino.Size = new System.Drawing.Size(105, 21);
            this.cmbAeropuertoDestino.TabIndex = 104;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 103;
            this.label9.Text = "Destino:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "Origen:";
            // 
            // cmbAeropuertoOrigen
            // 
            this.cmbAeropuertoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAeropuertoOrigen.FormattingEnabled = true;
            this.cmbAeropuertoOrigen.Location = new System.Drawing.Point(125, 16);
            this.cmbAeropuertoOrigen.Name = "cmbAeropuertoOrigen";
            this.cmbAeropuertoOrigen.Size = new System.Drawing.Size(112, 21);
            this.cmbAeropuertoOrigen.TabIndex = 101;
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
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(43, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 106);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pasajero";
            // 
            // cmbNroDocumento
            // 
            this.cmbNroDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNroDocumento.Enabled = false;
            this.cmbNroDocumento.FormattingEnabled = true;
            this.cmbNroDocumento.Location = new System.Drawing.Point(309, 19);
            this.cmbNroDocumento.Name = "cmbNroDocumento";
            this.cmbNroDocumento.Size = new System.Drawing.Size(121, 21);
            this.cmbNroDocumento.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Nro Documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Tipo Documento:";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.Enabled = false;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(105, 19);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(105, 21);
            this.cmbTipoDocumento.TabIndex = 65;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(373, 77);
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
            this.txtApellidoPasajero.Location = new System.Drawing.Point(73, 48);
            this.txtApellidoPasajero.Name = "txtApellidoPasajero";
            this.txtApellidoPasajero.ReadOnly = true;
            this.txtApellidoPasajero.Size = new System.Drawing.Size(137, 20);
            this.txtApellidoPasajero.TabIndex = 51;
            // 
            // txtNombrePasajero
            // 
            this.txtNombrePasajero.Enabled = false;
            this.txtNombrePasajero.Location = new System.Drawing.Point(279, 48);
            this.txtNombrePasajero.Name = "txtNombrePasajero";
            this.txtNombrePasajero.ReadOnly = true;
            this.txtNombrePasajero.Size = new System.Drawing.Size(149, 20);
            this.txtNombrePasajero.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Nombre:";
            // 
            // txtNroPasaje
            // 
            this.txtNroPasaje.Enabled = false;
            this.txtNroPasaje.Location = new System.Drawing.Point(108, 18);
            this.txtNroPasaje.Name = "txtNroPasaje";
            this.txtNroPasaje.ReadOnly = true;
            this.txtNroPasaje.Size = new System.Drawing.Size(138, 20);
            this.txtNroPasaje.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Nro Pasaje:";
            // 
            // cmbTipoPasaje
            // 
            this.cmbTipoPasaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPasaje.FormattingEnabled = true;
            this.cmbTipoPasaje.Location = new System.Drawing.Point(322, 18);
            this.cmbTipoPasaje.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoPasaje.Name = "cmbTipoPasaje";
            this.cmbTipoPasaje.Size = new System.Drawing.Size(134, 21);
            this.cmbTipoPasaje.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Tipo Pasaje:";
            // 
            // txtDecripcion
            // 
            this.txtDecripcion.Location = new System.Drawing.Point(133, 396);
            this.txtDecripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDecripcion.MaxLength = 50;
            this.txtDecripcion.Multiline = true;
            this.txtDecripcion.Name = "txtDecripcion";
            this.txtDecripcion.Size = new System.Drawing.Size(323, 46);
            this.txtDecripcion.TabIndex = 117;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 116;
            this.label7.Text = "Motivo de Viaje:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 118;
            this.label10.Text = "Fecha Llegada:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 47);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 117;
            this.label11.Text = "Fecha Salida:";
            // 
            // dtpFechaLlegada
            // 
            this.dtpFechaLlegada.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaLlegada.Location = new System.Drawing.Point(384, 43);
            this.dtpFechaLlegada.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpFechaLlegada.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpFechaLlegada.Name = "dtpFechaLlegada";
            this.dtpFechaLlegada.Size = new System.Drawing.Size(114, 20);
            this.dtpFechaLlegada.TabIndex = 116;
            this.dtpFechaLlegada.TabStop = false;
            this.dtpFechaLlegada.Value = new System.DateTime(2020, 10, 28, 17, 38, 32, 0);
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaSalida.Location = new System.Drawing.Point(125, 43);
            this.dtpFechaSalida.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpFechaSalida.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(114, 20);
            this.dtpFechaSalida.TabIndex = 115;
            this.dtpFechaSalida.TabStop = false;
            this.dtpFechaSalida.Value = new System.DateTime(2020, 10, 28, 0, 0, 0, 0);
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
            // formEditarPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "formEditarPasaje";
            this.Text = "Modificar Pasaje";
            this.Load += new System.EventHandler(this.formEditarPasaje_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNroDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.TextBox txtApellidoPasajero;
        private System.Windows.Forms.TextBox txtNombrePasajero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNroPasaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoPasaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmbAeropuertoDestino;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbAeropuertoOrigen;
        private System.Windows.Forms.DataGridView dgvVuelos;
        private System.Windows.Forms.TextBox txtDecripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegada;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
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