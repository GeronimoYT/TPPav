namespace Principal.Transacciones
{
    partial class formEmbarque
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
            this.lblEmbarque = new System.Windows.Forms.Label();
            this.lblNroVuelo = new System.Windows.Forms.Label();
            this.cmbNroVuelo = new System.Windows.Forms.ComboBox();
            this.lblFechaEmbarque = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPuertaEmbarque = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cmbNroDoc = new System.Windows.Forms.ComboBox();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptarEdicion = new System.Windows.Forms.Button();
            this.btnEditarAeropuerto = new System.Windows.Forms.Button();
            this.cmbPuertaEmbarque = new System.Windows.Forms.ComboBox();
            this.txtFechaEmbarque = new System.Windows.Forms.MaskedTextBox();
            this.txtAeropuerto = new System.Windows.Forms.TextBox();
            this.btnPasajero = new System.Windows.Forms.Button();
            this.gbEmbarque = new System.Windows.Forms.GroupBox();
            this.txtNvoNroDoc = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.dgvVuelo = new System.Windows.Forms.DataGridView();
            this.FechaHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AeropuertoSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AeropuertoLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDatosEmbarques = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.NroVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraEmbarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDNIPasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDNIPasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEmbarque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEmbarques)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmbarque
            // 
            this.lblEmbarque.AutoSize = true;
            this.lblEmbarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmbarque.Location = new System.Drawing.Point(12, 9);
            this.lblEmbarque.Name = "lblEmbarque";
            this.lblEmbarque.Size = new System.Drawing.Size(91, 20);
            this.lblEmbarque.TabIndex = 0;
            this.lblEmbarque.Text = "Embarque";
            // 
            // lblNroVuelo
            // 
            this.lblNroVuelo.AutoSize = true;
            this.lblNroVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroVuelo.Location = new System.Drawing.Point(16, 17);
            this.lblNroVuelo.Name = "lblNroVuelo";
            this.lblNroVuelo.Size = new System.Drawing.Size(127, 17);
            this.lblNroVuelo.TabIndex = 1;
            this.lblNroVuelo.Text = "Número de Vuelo*:";
            // 
            // cmbNroVuelo
            // 
            this.cmbNroVuelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNroVuelo.FormattingEnabled = true;
            this.cmbNroVuelo.Location = new System.Drawing.Point(194, 16);
            this.cmbNroVuelo.Name = "cmbNroVuelo";
            this.cmbNroVuelo.Size = new System.Drawing.Size(70, 21);
            this.cmbNroVuelo.TabIndex = 64;
            this.cmbNroVuelo.SelectedIndexChanged += new System.EventHandler(this.cmbNroVuelo_SelectedIndexChanged);
            // 
            // lblFechaEmbarque
            // 
            this.lblFechaEmbarque.AutoSize = true;
            this.lblFechaEmbarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmbarque.Location = new System.Drawing.Point(415, 123);
            this.lblFechaEmbarque.Name = "lblFechaEmbarque";
            this.lblFechaEmbarque.Size = new System.Drawing.Size(186, 17);
            this.lblFechaEmbarque.TabIndex = 67;
            this.lblFechaEmbarque.Text = "Fecha y Hora de Embarque:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Aeropuerto de Embarque:";
            // 
            // lblPuertaEmbarque
            // 
            this.lblPuertaEmbarque.AutoSize = true;
            this.lblPuertaEmbarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuertaEmbarque.Location = new System.Drawing.Point(415, 198);
            this.lblPuertaEmbarque.Name = "lblPuertaEmbarque";
            this.lblPuertaEmbarque.Size = new System.Drawing.Size(143, 17);
            this.lblPuertaEmbarque.TabIndex = 71;
            this.lblPuertaEmbarque.Text = "Puerta de Embarque:";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.Enabled = false;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(194, 194);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(109, 21);
            this.cmbTipoDoc.TabIndex = 75;
            this.cmbTipoDoc.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDoc_SelectedIndexChanged);
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(27, 198);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(116, 17);
            this.lblTipoDoc.TabIndex = 74;
            this.lblTipoDoc.Text = "Tipo Documento:";
            // 
            // cmbNroDoc
            // 
            this.cmbNroDoc.DisplayMember = "123123123";
            this.cmbNroDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNroDoc.Enabled = false;
            this.cmbNroDoc.FormattingEnabled = true;
            this.cmbNroDoc.Location = new System.Drawing.Point(194, 272);
            this.cmbNroDoc.Name = "cmbNroDoc";
            this.cmbNroDoc.Size = new System.Drawing.Size(109, 21);
            this.cmbNroDoc.TabIndex = 77;
            this.cmbNroDoc.ValueMember = "123123123";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDoc.Location = new System.Drawing.Point(27, 272);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(158, 17);
            this.lblNroDoc.TabIndex = 76;
            this.lblNroDoc.Text = "Número de Documento:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(540, 268);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(176, 21);
            this.cmbEstado.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "Estado:";
            // 
            // btnAceptarEdicion
            // 
            this.btnAceptarEdicion.Enabled = false;
            this.btnAceptarEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarEdicion.Location = new System.Drawing.Point(674, 392);
            this.btnAceptarEdicion.Name = "btnAceptarEdicion";
            this.btnAceptarEdicion.Size = new System.Drawing.Size(75, 28);
            this.btnAceptarEdicion.TabIndex = 83;
            this.btnAceptarEdicion.Text = "Cargar";
            this.btnAceptarEdicion.UseVisualStyleBackColor = true;
            this.btnAceptarEdicion.Click += new System.EventHandler(this.btnAceptarEdicion_Click);
            // 
            // btnEditarAeropuerto
            // 
            this.btnEditarAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAeropuerto.Location = new System.Drawing.Point(576, 392);
            this.btnEditarAeropuerto.Name = "btnEditarAeropuerto";
            this.btnEditarAeropuerto.Size = new System.Drawing.Size(75, 28);
            this.btnEditarAeropuerto.TabIndex = 82;
            this.btnEditarAeropuerto.Text = "Cancelar";
            this.btnEditarAeropuerto.UseVisualStyleBackColor = true;
            this.btnEditarAeropuerto.Click += new System.EventHandler(this.btnEditarAeropuerto_Click);
            // 
            // cmbPuertaEmbarque
            // 
            this.cmbPuertaEmbarque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuertaEmbarque.Enabled = false;
            this.cmbPuertaEmbarque.FormattingEnabled = true;
            this.cmbPuertaEmbarque.Location = new System.Drawing.Point(607, 194);
            this.cmbPuertaEmbarque.Name = "cmbPuertaEmbarque";
            this.cmbPuertaEmbarque.Size = new System.Drawing.Size(70, 21);
            this.cmbPuertaEmbarque.TabIndex = 84;
            // 
            // txtFechaEmbarque
            // 
            this.txtFechaEmbarque.Enabled = false;
            this.txtFechaEmbarque.Location = new System.Drawing.Point(607, 122);
            this.txtFechaEmbarque.Mask = "00/00/0000 00:00";
            this.txtFechaEmbarque.Name = "txtFechaEmbarque";
            this.txtFechaEmbarque.Size = new System.Drawing.Size(112, 20);
            this.txtFechaEmbarque.TabIndex = 85;
            this.txtFechaEmbarque.ValidatingType = typeof(System.DateTime);
            // 
            // txtAeropuerto
            // 
            this.txtAeropuerto.Enabled = false;
            this.txtAeropuerto.Location = new System.Drawing.Point(194, 122);
            this.txtAeropuerto.Name = "txtAeropuerto";
            this.txtAeropuerto.ReadOnly = true;
            this.txtAeropuerto.Size = new System.Drawing.Size(132, 20);
            this.txtAeropuerto.TabIndex = 86;
            this.txtAeropuerto.TextChanged += new System.EventHandler(this.txtAeropuerto_TextChanged);
            // 
            // btnPasajero
            // 
            this.btnPasajero.Enabled = false;
            this.btnPasajero.Location = new System.Drawing.Point(194, 330);
            this.btnPasajero.Name = "btnPasajero";
            this.btnPasajero.Size = new System.Drawing.Size(75, 23);
            this.btnPasajero.TabIndex = 89;
            this.btnPasajero.Text = "Agregar";
            this.btnPasajero.UseVisualStyleBackColor = true;
            this.btnPasajero.Click += new System.EventHandler(this.btnPasajero_Click);
            // 
            // gbEmbarque
            // 
            this.gbEmbarque.Controls.Add(this.txtNvoNroDoc);
            this.gbEmbarque.Controls.Add(this.btnConsulta);
            this.gbEmbarque.Controls.Add(this.dgvVuelo);
            this.gbEmbarque.Controls.Add(this.btnPasajero);
            this.gbEmbarque.Controls.Add(this.lblNroVuelo);
            this.gbEmbarque.Controls.Add(this.cmbNroVuelo);
            this.gbEmbarque.Controls.Add(this.txtAeropuerto);
            this.gbEmbarque.Controls.Add(this.lblFechaEmbarque);
            this.gbEmbarque.Controls.Add(this.txtFechaEmbarque);
            this.gbEmbarque.Controls.Add(this.label2);
            this.gbEmbarque.Controls.Add(this.cmbPuertaEmbarque);
            this.gbEmbarque.Controls.Add(this.lblPuertaEmbarque);
            this.gbEmbarque.Controls.Add(this.lblTipoDoc);
            this.gbEmbarque.Controls.Add(this.cmbTipoDoc);
            this.gbEmbarque.Controls.Add(this.cmbEstado);
            this.gbEmbarque.Controls.Add(this.lblNroDoc);
            this.gbEmbarque.Controls.Add(this.label1);
            this.gbEmbarque.Controls.Add(this.cmbNroDoc);
            this.gbEmbarque.Location = new System.Drawing.Point(12, 27);
            this.gbEmbarque.Name = "gbEmbarque";
            this.gbEmbarque.Size = new System.Drawing.Size(737, 359);
            this.gbEmbarque.TabIndex = 90;
            this.gbEmbarque.TabStop = false;
            // 
            // txtNvoNroDoc
            // 
            this.txtNvoNroDoc.Enabled = false;
            this.txtNvoNroDoc.Location = new System.Drawing.Point(194, 304);
            this.txtNvoNroDoc.MaxLength = 9;
            this.txtNvoNroDoc.Name = "txtNvoNroDoc";
            this.txtNvoNroDoc.Size = new System.Drawing.Size(109, 20);
            this.txtNvoNroDoc.TabIndex = 92;
            this.txtNvoNroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNvoNroDoc_KeyPress);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Enabled = false;
            this.btnConsulta.Location = new System.Drawing.Point(281, 14);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 91;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvVuelo
            // 
            this.dgvVuelo.AllowUserToAddRows = false;
            this.dgvVuelo.AllowUserToDeleteRows = false;
            this.dgvVuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVuelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaHoraSalida,
            this.AeropuertoSalida,
            this.AeropuertoLlegada});
            this.dgvVuelo.Location = new System.Drawing.Point(389, 14);
            this.dgvVuelo.Name = "dgvVuelo";
            this.dgvVuelo.ReadOnly = true;
            this.dgvVuelo.Size = new System.Drawing.Size(330, 102);
            this.dgvVuelo.TabIndex = 90;
            // 
            // FechaHoraSalida
            // 
            this.FechaHoraSalida.DataPropertyName = "FechaHoraSalida";
            this.FechaHoraSalida.HeaderText = "Fecha Hora Salida";
            this.FechaHoraSalida.Name = "FechaHoraSalida";
            this.FechaHoraSalida.ReadOnly = true;
            // 
            // AeropuertoSalida
            // 
            this.AeropuertoSalida.DataPropertyName = "AeropuertoSalida";
            this.AeropuertoSalida.HeaderText = "Aeropuerto Salida";
            this.AeropuertoSalida.Name = "AeropuertoSalida";
            this.AeropuertoSalida.ReadOnly = true;
            // 
            // AeropuertoLlegada
            // 
            this.AeropuertoLlegada.DataPropertyName = "AeropuertoLlegada";
            this.AeropuertoLlegada.HeaderText = "Aeropuerto Llegada";
            this.AeropuertoLlegada.Name = "AeropuertoLlegada";
            this.AeropuertoLlegada.ReadOnly = true;
            this.AeropuertoLlegada.Width = 85;
            // 
            // dgvDatosEmbarques
            // 
            this.dgvDatosEmbarques.AllowUserToAddRows = false;
            this.dgvDatosEmbarques.AllowUserToDeleteRows = false;
            this.dgvDatosEmbarques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosEmbarques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroVuelo,
            this.FechaHoraEmbarque,
            this.TipoDNIPasajero,
            this.NroDNIPasajero});
            this.dgvDatosEmbarques.Location = new System.Drawing.Point(775, 41);
            this.dgvDatosEmbarques.Name = "dgvDatosEmbarques";
            this.dgvDatosEmbarques.ReadOnly = true;
            this.dgvDatosEmbarques.Size = new System.Drawing.Size(344, 275);
            this.dgvDatosEmbarques.TabIndex = 91;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1044, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 92;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NroVuelo
            // 
            this.NroVuelo.DataPropertyName = "NroVuelo";
            this.NroVuelo.HeaderText = "Nro Vuelo";
            this.NroVuelo.Name = "NroVuelo";
            this.NroVuelo.ReadOnly = true;
            this.NroVuelo.Width = 50;
            // 
            // FechaHoraEmbarque
            // 
            this.FechaHoraEmbarque.DataPropertyName = "FechaHoraEmbarque";
            this.FechaHoraEmbarque.HeaderText = "Fecha Hora Embarque";
            this.FechaHoraEmbarque.Name = "FechaHoraEmbarque";
            this.FechaHoraEmbarque.ReadOnly = true;
            this.FechaHoraEmbarque.Width = 95;
            // 
            // TipoDNIPasajero
            // 
            this.TipoDNIPasajero.DataPropertyName = "TipoDNIPasajero";
            this.TipoDNIPasajero.HeaderText = "Tipo Doc Pasajero";
            this.TipoDNIPasajero.Name = "TipoDNIPasajero";
            this.TipoDNIPasajero.ReadOnly = true;
            this.TipoDNIPasajero.Width = 75;
            // 
            // NroDNIPasajero
            // 
            this.NroDNIPasajero.DataPropertyName = "NroDNIPasajero";
            this.NroDNIPasajero.HeaderText = "Nro Doc Pasajero";
            this.NroDNIPasajero.Name = "NroDNIPasajero";
            this.NroDNIPasajero.ReadOnly = true;
            this.NroDNIPasajero.Width = 80;
            // 
            // formEmbarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDatosEmbarques);
            this.Controls.Add(this.btnAceptarEdicion);
            this.Controls.Add(this.btnEditarAeropuerto);
            this.Controls.Add(this.lblEmbarque);
            this.Controls.Add(this.gbEmbarque);
            this.Name = "formEmbarque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Embarque";
            this.gbEmbarque.ResumeLayout(false);
            this.gbEmbarque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEmbarques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmbarque;
        private System.Windows.Forms.Label lblNroVuelo;
        private System.Windows.Forms.ComboBox cmbNroVuelo;
        private System.Windows.Forms.Label lblFechaEmbarque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPuertaEmbarque;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cmbNroDoc;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptarEdicion;
        private System.Windows.Forms.Button btnEditarAeropuerto;
        private System.Windows.Forms.ComboBox cmbPuertaEmbarque;
        private System.Windows.Forms.MaskedTextBox txtFechaEmbarque;
        private System.Windows.Forms.TextBox txtAeropuerto;
        private System.Windows.Forms.Button btnPasajero;
        private System.Windows.Forms.GroupBox gbEmbarque;
        private System.Windows.Forms.DataGridView dgvVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn AeropuertoSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn AeropuertoLlegada;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtNvoNroDoc;
        private System.Windows.Forms.DataGridView dgvDatosEmbarques;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraEmbarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDNIPasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDNIPasajero;
    }
}