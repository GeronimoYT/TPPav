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
            this.label1 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Vuelo :";
            // 
            // txtNumVuelo
            // 
            this.txtNumVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumVuelo.Location = new System.Drawing.Point(96, 12);
            this.txtNumVuelo.Name = "txtNumVuelo";
            this.txtNumVuelo.Size = new System.Drawing.Size(163, 22);
            this.txtNumVuelo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha :";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(79, 11);
            this.monthCalendar1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hora :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "hs.";
            // 
            // cmbHoras
            // 
            this.cmbHoras.FormattingEnabled = true;
            this.cmbHoras.Location = new System.Drawing.Point(79, 183);
            this.cmbHoras.Name = "cmbHoras";
            this.cmbHoras.Size = new System.Drawing.Size(102, 24);
            this.cmbHoras.TabIndex = 8;
            this.cmbHoras.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "N° Avion :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbHoras);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 225);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SALIDA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.monthCalendar2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbHoras2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(383, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 225);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LLEGADA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "hs.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha :";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(74, 11);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.ShowToday = false;
            this.monthCalendar2.TabIndex = 4;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hora :";
            // 
            // cmbHoras2
            // 
            this.cmbHoras2.FormattingEnabled = true;
            this.cmbHoras2.Location = new System.Drawing.Point(74, 183);
            this.cmbHoras2.Name = "cmbHoras2";
            this.cmbHoras2.Size = new System.Drawing.Size(103, 24);
            this.cmbHoras2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Aeropuerto Origen :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Aeropuerto Destino :";
            // 
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
            // 
            // formVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
    }
}