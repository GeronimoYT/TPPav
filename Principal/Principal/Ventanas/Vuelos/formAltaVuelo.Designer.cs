namespace Principal.Ventanas
{
    partial class formAltaVuelo
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
            this.label3 = new System.Windows.Forms.Label();
            this.calendarioSalida = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHoraSalida = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calendarioLlegada = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbHoraLlegada = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbAeropuertoOrigen = new System.Windows.Forms.ComboBox();
            this.cmbAeropuertoDestino = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConfirmarVuelo = new System.Windows.Forms.Button();
            this.btnCancelarVuelo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTipoAvion = new System.Windows.Forms.TextBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.cmbNumAvion = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha :";
            // 
            // calendarioSalida
            // 
            this.calendarioSalida.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calendarioSalida.Location = new System.Drawing.Point(105, 14);
            this.calendarioSalida.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calendarioSalida.MaxDate = new System.DateTime(2021, 8, 31, 0, 0, 0, 0);
            this.calendarioSalida.MaxSelectionCount = 1;
            this.calendarioSalida.MinDate = new System.DateTime(2020, 11, 5, 0, 0, 0, 0);
            this.calendarioSalida.Name = "calendarioSalida";
            this.calendarioSalida.ShowToday = false;
            this.calendarioSalida.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hora :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "hs.";
            // 
            // cmbHoraSalida
            // 
            this.cmbHoraSalida.DropDownHeight = 200;
            this.cmbHoraSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraSalida.FormattingEnabled = true;
            this.cmbHoraSalida.IntegralHeight = false;
            this.cmbHoraSalida.ItemHeight = 20;
            this.cmbHoraSalida.Location = new System.Drawing.Point(105, 225);
            this.cmbHoraSalida.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHoraSalida.Name = "cmbHoraSalida";
            this.cmbHoraSalida.Size = new System.Drawing.Size(91, 28);
            this.cmbHoraSalida.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 309);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "N° Avion :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.calendarioSalida);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbHoraSalida);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(480, 277);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SALIDA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.calendarioLlegada);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbHoraLlegada);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(505, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(472, 277);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LLEGADA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "hs.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha :";
            // 
            // calendarioLlegada
            // 
            this.calendarioLlegada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calendarioLlegada.Location = new System.Drawing.Point(99, 14);
            this.calendarioLlegada.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calendarioLlegada.MaxDate = new System.DateTime(2021, 8, 31, 0, 0, 0, 0);
            this.calendarioLlegada.MaxSelectionCount = 1;
            this.calendarioLlegada.MinDate = new System.DateTime(2020, 11, 5, 0, 0, 0, 0);
            this.calendarioLlegada.Name = "calendarioLlegada";
            this.calendarioLlegada.ShowToday = false;
            this.calendarioLlegada.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hora :";
            // 
            // cmbHoraLlegada
            // 
            this.cmbHoraLlegada.DropDownHeight = 200;
            this.cmbHoraLlegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraLlegada.FormattingEnabled = true;
            this.cmbHoraLlegada.IntegralHeight = false;
            this.cmbHoraLlegada.Location = new System.Drawing.Point(99, 225);
            this.cmbHoraLlegada.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHoraLlegada.Name = "cmbHoraLlegada";
            this.cmbHoraLlegada.Size = new System.Drawing.Size(95, 28);
            this.cmbHoraLlegada.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 350);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Aeropuerto Origen :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 389);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Aeropuerto Destino :";
            // 
            // cmbAeropuertoOrigen
            // 
            this.cmbAeropuertoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAeropuertoOrigen.FormattingEnabled = true;
            this.cmbAeropuertoOrigen.Location = new System.Drawing.Point(211, 348);
            this.cmbAeropuertoOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAeropuertoOrigen.Name = "cmbAeropuertoOrigen";
            this.cmbAeropuertoOrigen.Size = new System.Drawing.Size(296, 24);
            this.cmbAeropuertoOrigen.TabIndex = 21;
            // 
            // cmbAeropuertoDestino
            // 
            this.cmbAeropuertoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAeropuertoDestino.FormattingEnabled = true;
            this.cmbAeropuertoDestino.Location = new System.Drawing.Point(211, 388);
            this.cmbAeropuertoDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAeropuertoDestino.Name = "cmbAeropuertoDestino";
            this.cmbAeropuertoDestino.Size = new System.Drawing.Size(296, 24);
            this.cmbAeropuertoDestino.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 436);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Estado :";
            // 
            // btnConfirmarVuelo
            // 
            this.btnConfirmarVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarVuelo.Location = new System.Drawing.Point(505, 482);
            this.btnConfirmarVuelo.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmarVuelo.Name = "btnConfirmarVuelo";
            this.btnConfirmarVuelo.Size = new System.Drawing.Size(184, 28);
            this.btnConfirmarVuelo.TabIndex = 25;
            this.btnConfirmarVuelo.Text = "Confirmar Vuelo";
            this.btnConfirmarVuelo.UseVisualStyleBackColor = true;
            this.btnConfirmarVuelo.Click += new System.EventHandler(this.btnConfirmarVuelo_Click);
            // 
            // btnCancelarVuelo
            // 
            this.btnCancelarVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVuelo.Location = new System.Drawing.Point(748, 482);
            this.btnCancelarVuelo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarVuelo.Name = "btnCancelarVuelo";
            this.btnCancelarVuelo.Size = new System.Drawing.Size(145, 28);
            this.btnCancelarVuelo.TabIndex = 26;
            this.btnCancelarVuelo.Text = "Cancelar";
            this.btnCancelarVuelo.UseVisualStyleBackColor = true;
            this.btnCancelarVuelo.Click += new System.EventHandler(this.btnCancelarVuelo_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(355, 310);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Tipo de Avion :";
            // 
            // txtTipoAvion
            // 
            this.txtTipoAvion.Enabled = false;
            this.txtTipoAvion.Location = new System.Drawing.Point(505, 309);
            this.txtTipoAvion.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoAvion.Name = "txtTipoAvion";
            this.txtTipoAvion.ReadOnly = true;
            this.txtTipoAvion.Size = new System.Drawing.Size(193, 22);
            this.txtTipoAvion.TabIndex = 31;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.Location = new System.Drawing.Point(748, 306);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(145, 28);
            this.btnDetalle.TabIndex = 33;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // cmbNumAvion
            // 
            this.cmbNumAvion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumAvion.FormattingEnabled = true;
            this.cmbNumAvion.Location = new System.Drawing.Point(123, 306);
            this.cmbNumAvion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNumAvion.Name = "cmbNumAvion";
            this.cmbNumAvion.Size = new System.Drawing.Size(176, 24);
            this.cmbNumAvion.TabIndex = 34;
            this.cmbNumAvion.SelectedIndexChanged += new System.EventHandler(this.cmbNumAvion_SelectedIndexChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(121, 436);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(177, 24);
            this.cmbEstado.TabIndex = 35;
            // 
            // formAltaVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 528);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbNumAvion);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.txtTipoAvion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCancelarVuelo);
            this.Controls.Add(this.btnConfirmarVuelo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbAeropuertoDestino);
            this.Controls.Add(this.cmbAeropuertoOrigen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formAltaVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AEROLINEA SALETARDE";
            this.Load += new System.EventHandler(this.formVuelo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar calendarioSalida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHoraSalida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar calendarioLlegada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbHoraLlegada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbAeropuertoOrigen;
        private System.Windows.Forms.ComboBox cmbAeropuertoDestino;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConfirmarVuelo;
        private System.Windows.Forms.Button btnCancelarVuelo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTipoAvion;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.ComboBox cmbNumAvion;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}