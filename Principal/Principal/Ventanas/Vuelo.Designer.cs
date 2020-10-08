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
            this.dgvVuelos = new System.Windows.Forms.DataGridView();
            this.NroVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAeropuerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).BeginInit();
=======
            this.txtNumVuelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHoras = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbHoras2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbAeropuerto1 = new System.Windows.Forms.ComboBox();
            this.cmbAeropuerto2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConfirmarVuelo = new System.Windows.Forms.Button();
            this.btnCancelarVuelo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTipoAvion = new System.Windows.Forms.TextBox();
            this.btnDetalleAvion = new System.Windows.Forms.Button();
            this.cmbNumAvion = new System.Windows.Forms.ComboBox();
            this.cmbEstadoVuelo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
>>>>>>> 4ca83d16b1e6cdb95bb7cf20c4bb0898cbef4b7e
            this.SuspendLayout();
            // 
            // dgvVuelos
            // 
            this.dgvVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroVuelo,
            this.FechaHoraSalida,
            this.FechaHoraLlegada,
            this.NroAvion,
            this.IdTipoAvion,
            this.IdAeropuerto,
            this.Estado});
            this.dgvVuelos.Location = new System.Drawing.Point(12, 41);
            this.dgvVuelos.Name = "dgvVuelos";
            this.dgvVuelos.Size = new System.Drawing.Size(738, 195);
            this.dgvVuelos.TabIndex = 5;
            // 
            // NroVuelo
            // 
            this.NroVuelo.HeaderText = "NroVuelo";
            this.NroVuelo.Name = "NroVuelo";
            // 
            // FechaHoraSalida
            // 
            this.FechaHoraSalida.HeaderText = "FechaHoraSalida";
            this.FechaHoraSalida.Name = "FechaHoraSalida";
            // 
            // FechaHoraLlegada
            // 
            this.FechaHoraLlegada.HeaderText = "FechaHoraLlegada";
            this.FechaHoraLlegada.Name = "FechaHoraLlegada";
            // 
            // NroAvion
            // 
            this.NroAvion.HeaderText = "NroAvion";
            this.NroAvion.Name = "NroAvion";
            // 
            // IdTipoAvion
            // 
            this.IdTipoAvion.HeaderText = "IdTipoAvion";
            this.IdTipoAvion.Name = "IdTipoAvion";
            // 
            // IdAeropuerto
            // 
            this.IdAeropuerto.HeaderText = "IdDestino";
            this.IdAeropuerto.Name = "IdAeropuerto";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
<<<<<<< HEAD
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "VUELOS PROGRAMADOS";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(767, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 25);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(767, 82);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 26);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(767, 123);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(98, 25);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(767, 256);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 27);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
=======
            // cmbAeropuerto1
            // 
            this.cmbAeropuerto1.FormattingEnabled = true;
            this.cmbAeropuerto1.Location = new System.Drawing.Point(162, 314);
            this.cmbAeropuerto1.Name = "cmbAeropuerto1";
            this.cmbAeropuerto1.Size = new System.Drawing.Size(299, 21);
            this.cmbAeropuerto1.TabIndex = 21;
            // 
            // cmbAeropuerto2
            // 
            this.cmbAeropuerto2.FormattingEnabled = true;
            this.cmbAeropuerto2.Location = new System.Drawing.Point(162, 346);
            this.cmbAeropuerto2.Name = "cmbAeropuerto2";
            this.cmbAeropuerto2.Size = new System.Drawing.Size(299, 21);
            this.cmbAeropuerto2.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Estado :";
            // 
            // btnConfirmarVuelo
            // 
            this.btnConfirmarVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarVuelo.Location = new System.Drawing.Point(422, 423);
            this.btnConfirmarVuelo.Name = "btnConfirmarVuelo";
            this.btnConfirmarVuelo.Size = new System.Drawing.Size(138, 23);
            this.btnConfirmarVuelo.TabIndex = 25;
            this.btnConfirmarVuelo.Text = "Confirmar Vuelo";
            this.btnConfirmarVuelo.UseVisualStyleBackColor = true;
            // 
            // btnCancelarVuelo
            // 
            this.btnCancelarVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVuelo.Location = new System.Drawing.Point(596, 423);
            this.btnCancelarVuelo.Name = "btnCancelarVuelo";
            this.btnCancelarVuelo.Size = new System.Drawing.Size(109, 23);
            this.btnCancelarVuelo.TabIndex = 26;
            this.btnCancelarVuelo.Text = "Cancelar";
            this.btnCancelarVuelo.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(214, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Tipo de Avion :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtTipoAvion
            // 
            this.txtTipoAvion.Location = new System.Drawing.Point(318, 282);
            this.txtTipoAvion.Name = "txtTipoAvion";
            this.txtTipoAvion.Size = new System.Drawing.Size(143, 20);
            this.txtTipoAvion.TabIndex = 31;
            // 
            // btnDetalleAvion
            // 
            this.btnDetalleAvion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleAvion.Location = new System.Drawing.Point(482, 280);
            this.btnDetalleAvion.Name = "btnDetalleAvion";
            this.btnDetalleAvion.Size = new System.Drawing.Size(109, 23);
            this.btnDetalleAvion.TabIndex = 33;
            this.btnDetalleAvion.Text = "Detalle";
            this.btnDetalleAvion.UseVisualStyleBackColor = true;
            this.btnDetalleAvion.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cmbNumAvion
            // 
            this.cmbNumAvion.FormattingEnabled = true;
            this.cmbNumAvion.Location = new System.Drawing.Point(96, 280);
            this.cmbNumAvion.Name = "cmbNumAvion";
            this.cmbNumAvion.Size = new System.Drawing.Size(102, 21);
            this.cmbNumAvion.TabIndex = 34;
            // 
            // cmbEstadoVuelo
            // 
            this.cmbEstadoVuelo.FormattingEnabled = true;
            this.cmbEstadoVuelo.Location = new System.Drawing.Point(95, 385);
            this.cmbEstadoVuelo.Name = "cmbEstadoVuelo";
            this.cmbEstadoVuelo.Size = new System.Drawing.Size(134, 21);
            this.cmbEstadoVuelo.TabIndex = 35;
>>>>>>> 4ca83d16b1e6cdb95bb7cf20c4bb0898cbef4b7e
            // 
            // formVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(886, 295);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVuelos);
            this.Name = "Vuelo";
            this.Text = "AEROLINEA SALETARDE";
            this.Load += new System.EventHandler(this.Vuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).EndInit();
=======
            this.ClientSize = new System.Drawing.Size(745, 476);
            this.Controls.Add(this.cmbEstadoVuelo);
            this.Controls.Add(this.cmbNumAvion);
            this.Controls.Add(this.btnDetalleAvion);
            this.Controls.Add(this.txtTipoAvion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCancelarVuelo);
            this.Controls.Add(this.btnConfirmarVuelo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbAeropuerto2);
            this.Controls.Add(this.cmbAeropuerto1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNumVuelo);
            this.Controls.Add(this.label1);
            this.Name = "formVuelo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
>>>>>>> 4ca83d16b1e6cdb95bb7cf20c4bb0898cbef4b7e
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVuelos;
        private System.Windows.Forms.Label label1;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAeropuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
=======
        private System.Windows.Forms.TextBox txtNumVuelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHoras;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbHoras2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbAeropuerto1;
        private System.Windows.Forms.ComboBox cmbAeropuerto2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConfirmarVuelo;
        private System.Windows.Forms.Button btnCancelarVuelo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTipoAvion;
        private System.Windows.Forms.Button btnDetalleAvion;
        private System.Windows.Forms.ComboBox cmbNumAvion;
        private System.Windows.Forms.ComboBox cmbEstadoVuelo;
>>>>>>> 4ca83d16b1e6cdb95bb7cf20c4bb0898cbef4b7e
    }
}