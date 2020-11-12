namespace Principal.Ventanas
{
    partial class formVuelo
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVuelos = new System.Windows.Forms.DataGridView();
            this.NroVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAeropuerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAeropuertoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFL = new System.Windows.Forms.CheckBox();
            this.cbFS = new System.Windows.Forms.CheckBox();
            this.cmbAD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.filtroFL = new System.Windows.Forms.DateTimePicker();
            this.cmbE = new System.Windows.Forms.ComboBox();
            this.cmbNA = new System.Windows.Forms.ComboBox();
            this.filtroFS = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(701, 497);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(131, 33);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(281, 501);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(113, 31);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(144, 500);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 32);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(20, 500);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 31);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "VUELOS PROGRAMADOS";
            // 
            // dgvVuelos
            // 
            this.dgvVuelos.AllowUserToAddRows = false;
            this.dgvVuelos.AllowUserToDeleteRows = false;
            this.dgvVuelos.AllowUserToResizeRows = false;
            this.dgvVuelos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroVuelo,
            this.FechaHoraSalida,
            this.FechaHoraLlegada,
            this.NroAvion,
            this.IdTipoAvion,
            this.IdAeropuerto,
            this.IdAeropuertoDestino,
            this.Estado});
            this.dgvVuelos.Location = new System.Drawing.Point(20, 250);
            this.dgvVuelos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVuelos.MultiSelect = false;
            this.dgvVuelos.Name = "dgvVuelos";
            this.dgvVuelos.ReadOnly = true;
            this.dgvVuelos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVuelos.RowHeadersWidth = 51;
            this.dgvVuelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVuelos.Size = new System.Drawing.Size(845, 240);
            this.dgvVuelos.TabIndex = 11;
            this.dgvVuelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVuelos_CellContentClick);
            // 
            // NroVuelo
            // 
            this.NroVuelo.DataPropertyName = "NroVuelo";
            this.NroVuelo.HeaderText = "N°Vuelo";
            this.NroVuelo.MinimumWidth = 6;
            this.NroVuelo.Name = "NroVuelo";
            this.NroVuelo.ReadOnly = true;
            this.NroVuelo.Width = 70;
            // 
            // FechaHoraSalida
            // 
            this.FechaHoraSalida.DataPropertyName = "FechaHoraSalida";
            this.FechaHoraSalida.HeaderText = "FechaHoraSalida";
            this.FechaHoraSalida.MinimumWidth = 6;
            this.FechaHoraSalida.Name = "FechaHoraSalida";
            this.FechaHoraSalida.ReadOnly = true;
            this.FechaHoraSalida.Width = 120;
            // 
            // FechaHoraLlegada
            // 
            this.FechaHoraLlegada.DataPropertyName = "FechaHoraLlegada";
            this.FechaHoraLlegada.HeaderText = "FechaHoraLlegada";
            this.FechaHoraLlegada.MinimumWidth = 6;
            this.FechaHoraLlegada.Name = "FechaHoraLlegada";
            this.FechaHoraLlegada.ReadOnly = true;
            this.FechaHoraLlegada.Width = 120;
            // 
            // NroAvion
            // 
            this.NroAvion.DataPropertyName = "NroAvion";
            this.NroAvion.HeaderText = "Avion";
            this.NroAvion.MinimumWidth = 6;
            this.NroAvion.Name = "NroAvion";
            this.NroAvion.ReadOnly = true;
            this.NroAvion.Width = 70;
            // 
            // IdTipoAvion
            // 
            this.IdTipoAvion.DataPropertyName = "IdTipoAvion";
            this.IdTipoAvion.HeaderText = "TipoAvion";
            this.IdTipoAvion.MinimumWidth = 6;
            this.IdTipoAvion.Name = "IdTipoAvion";
            this.IdTipoAvion.ReadOnly = true;
            this.IdTipoAvion.Width = 90;
            // 
            // IdAeropuerto
            // 
            this.IdAeropuerto.DataPropertyName = "IdAeropuerto";
            this.IdAeropuerto.HeaderText = "AeropuertoOrigen";
            this.IdAeropuerto.MinimumWidth = 6;
            this.IdAeropuerto.Name = "IdAeropuerto";
            this.IdAeropuerto.ReadOnly = true;
            this.IdAeropuerto.Width = 125;
            // 
            // IdAeropuertoDestino
            // 
            this.IdAeropuertoDestino.DataPropertyName = "IdAeropuertoDestino";
            this.IdAeropuertoDestino.HeaderText = "AeropuertoDestino";
            this.IdAeropuertoDestino.MinimumWidth = 6;
            this.IdAeropuertoDestino.Name = "IdAeropuertoDestino";
            this.IdAeropuertoDestino.ReadOnly = true;
            this.IdAeropuertoDestino.Width = 125;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha Salida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fecha Llegada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "N° de Avion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Estado:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.cbFL);
            this.groupBox1.Controls.Add(this.cbFS);
            this.groupBox1.Controls.Add(this.cmbAD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbAO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.filtroFL);
            this.groupBox1.Controls.Add(this.cmbE);
            this.groupBox1.Controls.Add(this.cmbNA);
            this.groupBox1.Controls.Add(this.filtroFS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(849, 183);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONSULTA VUELOS";
            // 
            // cbFL
            // 
            this.cbFL.AutoSize = true;
            this.cbFL.Location = new System.Drawing.Point(770, 33);
            this.cbFL.Name = "cbFL";
            this.cbFL.Size = new System.Drawing.Size(18, 17);
            this.cbFL.TabIndex = 35;
            this.cbFL.UseVisualStyleBackColor = true;
            this.cbFL.CheckedChanged += new System.EventHandler(this.cbFL_CheckedChanged);
            // 
            // cbFS
            // 
            this.cbFS.AutoSize = true;
            this.cbFS.Location = new System.Drawing.Point(360, 33);
            this.cbFS.Name = "cbFS";
            this.cbFS.Size = new System.Drawing.Size(18, 17);
            this.cbFS.TabIndex = 34;
            this.cbFS.UseVisualStyleBackColor = true;
            this.cbFS.CheckedChanged += new System.EventHandler(this.cbFS_CheckedChanged);
            // 
            // cmbAD
            // 
            this.cmbAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAD.FormattingEnabled = true;
            this.cmbAD.Location = new System.Drawing.Point(580, 63);
            this.cmbAD.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAD.Name = "cmbAD";
            this.cmbAD.Size = new System.Drawing.Size(185, 28);
            this.cmbAD.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(418, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Aeropuerto Destino:";
            // 
            // cmbAO
            // 
            this.cmbAO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAO.FormattingEnabled = true;
            this.cmbAO.Location = new System.Drawing.Point(168, 64);
            this.cmbAO.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAO.Name = "cmbAO";
            this.cmbAO.Size = new System.Drawing.Size(185, 28);
            this.cmbAO.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Aeropuerto Origen:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(582, 134);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(183, 28);
            this.btnConsultar.TabIndex = 29;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // filtroFL
            // 
            this.filtroFL.CustomFormat = "";
            this.filtroFL.Enabled = false;
            this.filtroFL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.filtroFL.Location = new System.Drawing.Point(582, 27);
            this.filtroFL.Margin = new System.Windows.Forms.Padding(4);
            this.filtroFL.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.filtroFL.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.filtroFL.Name = "filtroFL";
            this.filtroFL.Size = new System.Drawing.Size(181, 26);
            this.filtroFL.TabIndex = 28;
            this.filtroFL.TabStop = false;
            this.filtroFL.Value = new System.DateTime(2020, 11, 11, 0, 0, 0, 0);
            // 
            // cmbE
            // 
            this.cmbE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbE.FormattingEnabled = true;
            this.cmbE.Location = new System.Drawing.Point(167, 135);
            this.cmbE.Margin = new System.Windows.Forms.Padding(4);
            this.cmbE.Name = "cmbE";
            this.cmbE.Size = new System.Drawing.Size(185, 28);
            this.cmbE.TabIndex = 27;
            // 
            // cmbNA
            // 
            this.cmbNA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNA.FormattingEnabled = true;
            this.cmbNA.Location = new System.Drawing.Point(168, 100);
            this.cmbNA.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNA.Name = "cmbNA";
            this.cmbNA.Size = new System.Drawing.Size(185, 28);
            this.cmbNA.TabIndex = 26;
            // 
            // filtroFS
            // 
            this.filtroFS.CustomFormat = "";
            this.filtroFS.Enabled = false;
            this.filtroFS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.filtroFS.Location = new System.Drawing.Point(168, 27);
            this.filtroFS.Margin = new System.Windows.Forms.Padding(4);
            this.filtroFS.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.filtroFS.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.filtroFS.Name = "filtroFS";
            this.filtroFS.Size = new System.Drawing.Size(185, 26);
            this.filtroFS.TabIndex = 24;
            this.filtroFS.TabStop = false;
            this.filtroFS.Value = new System.DateTime(2020, 11, 11, 0, 0, 0, 0);
            // 
            // formVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 549);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVuelos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vuelo";
            this.Load += new System.EventHandler(this.Vuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVuelos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbE;
        private System.Windows.Forms.ComboBox cmbNA;
        private System.Windows.Forms.DateTimePicker filtroFS;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker filtroFL;
        private System.Windows.Forms.ComboBox cmbAO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAeropuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAeropuertoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.CheckBox cbFL;
        private System.Windows.Forms.CheckBox cbFS;
    }
}