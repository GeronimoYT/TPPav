namespace Principal.Ventanas.Vuelos
{
    partial class formModificarVuelo
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
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NuevaFechaL = new System.Windows.Forms.DateTimePicker();
            this.NuevaFechaS = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNuevoTA = new System.Windows.Forms.TextBox();
            this.cmbHoraSalida = new System.Windows.Forms.ComboBox();
            this.cmbHoraLlegada = new System.Windows.Forms.ComboBox();
            this.cmbNuevoA = new System.Windows.Forms.ComboBox();
            this.cmbNuevoAO = new System.Windows.Forms.ComboBox();
            this.cmbNuevoAD = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarVuelo = new System.Windows.Forms.Button();
            this.btnConfirmarVuelo = new System.Windows.Forms.Button();
            this.cmbNuevoEstado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 36);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Fecha Salida :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Fecha Llegada :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "N° de Avion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tipo de Avion :";
            // 
            // NuevaFechaL
            // 
            this.NuevaFechaL.CustomFormat = "";
            this.NuevaFechaL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NuevaFechaL.Location = new System.Drawing.Point(171, 71);
            this.NuevaFechaL.Margin = new System.Windows.Forms.Padding(4);
            this.NuevaFechaL.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.NuevaFechaL.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.NuevaFechaL.Name = "NuevaFechaL";
            this.NuevaFechaL.Size = new System.Drawing.Size(185, 27);
            this.NuevaFechaL.TabIndex = 39;
            this.NuevaFechaL.TabStop = false;
            this.NuevaFechaL.Value = new System.DateTime(2020, 11, 10, 0, 0, 0, 0);
            // 
            // NuevaFechaS
            // 
            this.NuevaFechaS.CustomFormat = "";
            this.NuevaFechaS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NuevaFechaS.Location = new System.Drawing.Point(171, 32);
            this.NuevaFechaS.Margin = new System.Windows.Forms.Padding(4);
            this.NuevaFechaS.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.NuevaFechaS.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.NuevaFechaS.Name = "NuevaFechaS";
            this.NuevaFechaS.Size = new System.Drawing.Size(185, 27);
            this.NuevaFechaS.TabIndex = 38;
            this.NuevaFechaS.TabStop = false;
            this.NuevaFechaS.Value = new System.DateTime(2020, 11, 10, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Hora Salida :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Hora Llegada :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(591, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "hs.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(591, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "hs.";
            // 
            // txtNuevoTA
            // 
            this.txtNuevoTA.Enabled = false;
            this.txtNuevoTA.Location = new System.Drawing.Point(436, 111);
            this.txtNuevoTA.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuevoTA.Name = "txtNuevoTA";
            this.txtNuevoTA.ReadOnly = true;
            this.txtNuevoTA.Size = new System.Drawing.Size(181, 27);
            this.txtNuevoTA.TabIndex = 45;
            // 
            // cmbHoraSalida
            // 
            this.cmbHoraSalida.DropDownHeight = 200;
            this.cmbHoraSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraSalida.FormattingEnabled = true;
            this.cmbHoraSalida.IntegralHeight = false;
            this.cmbHoraSalida.ItemHeight = 20;
            this.cmbHoraSalida.Location = new System.Drawing.Point(491, 34);
            this.cmbHoraSalida.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHoraSalida.Name = "cmbHoraSalida";
            this.cmbHoraSalida.Size = new System.Drawing.Size(91, 28);
            this.cmbHoraSalida.TabIndex = 46;
            // 
            // cmbHoraLlegada
            // 
            this.cmbHoraLlegada.DropDownHeight = 200;
            this.cmbHoraLlegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraLlegada.FormattingEnabled = true;
            this.cmbHoraLlegada.IntegralHeight = false;
            this.cmbHoraLlegada.ItemHeight = 20;
            this.cmbHoraLlegada.Location = new System.Drawing.Point(492, 73);
            this.cmbHoraLlegada.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHoraLlegada.Name = "cmbHoraLlegada";
            this.cmbHoraLlegada.Size = new System.Drawing.Size(91, 28);
            this.cmbHoraLlegada.TabIndex = 47;
            // 
            // cmbNuevoA
            // 
            this.cmbNuevoA.DropDownHeight = 200;
            this.cmbNuevoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNuevoA.FormattingEnabled = true;
            this.cmbNuevoA.IntegralHeight = false;
            this.cmbNuevoA.ItemHeight = 20;
            this.cmbNuevoA.Location = new System.Drawing.Point(171, 111);
            this.cmbNuevoA.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNuevoA.Name = "cmbNuevoA";
            this.cmbNuevoA.Size = new System.Drawing.Size(91, 28);
            this.cmbNuevoA.TabIndex = 48;
            this.cmbNuevoA.SelectedIndexChanged += new System.EventHandler(this.cmbNuevoA_SelectedIndexChanged);
            // 
            // cmbNuevoAO
            // 
            this.cmbNuevoAO.DropDownHeight = 200;
            this.cmbNuevoAO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNuevoAO.FormattingEnabled = true;
            this.cmbNuevoAO.IntegralHeight = false;
            this.cmbNuevoAO.ItemHeight = 20;
            this.cmbNuevoAO.Location = new System.Drawing.Point(195, 161);
            this.cmbNuevoAO.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNuevoAO.Name = "cmbNuevoAO";
            this.cmbNuevoAO.Size = new System.Drawing.Size(231, 28);
            this.cmbNuevoAO.TabIndex = 49;
            // 
            // cmbNuevoAD
            // 
            this.cmbNuevoAD.DropDownHeight = 200;
            this.cmbNuevoAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNuevoAD.FormattingEnabled = true;
            this.cmbNuevoAD.IntegralHeight = false;
            this.cmbNuevoAD.ItemHeight = 20;
            this.cmbNuevoAD.Location = new System.Drawing.Point(195, 203);
            this.cmbNuevoAD.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNuevoAD.Name = "cmbNuevoAD";
            this.cmbNuevoAD.Size = new System.Drawing.Size(231, 28);
            this.cmbNuevoAD.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 208);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Aeropuerto Destino :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Aeropuerto Origen :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelarVuelo);
            this.groupBox1.Controls.Add(this.btnConfirmarVuelo);
            this.groupBox1.Controls.Add(this.cmbNuevoEstado);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbNuevoAD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbNuevoAO);
            this.groupBox1.Controls.Add(this.NuevaFechaS);
            this.groupBox1.Controls.Add(this.cmbNuevoA);
            this.groupBox1.Controls.Add(this.NuevaFechaL);
            this.groupBox1.Controls.Add(this.cmbHoraLlegada);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbHoraSalida);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNuevoTA);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(647, 353);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL VUELO";
            // 
            // btnCancelarVuelo
            // 
            this.btnCancelarVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVuelo.Location = new System.Drawing.Point(501, 310);
            this.btnCancelarVuelo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarVuelo.Name = "btnCancelarVuelo";
            this.btnCancelarVuelo.Size = new System.Drawing.Size(117, 28);
            this.btnCancelarVuelo.TabIndex = 57;
            this.btnCancelarVuelo.Text = "Cancelar";
            this.btnCancelarVuelo.UseVisualStyleBackColor = true;
            this.btnCancelarVuelo.Click += new System.EventHandler(this.btnCancelarVuelo_Click);
            // 
            // btnConfirmarVuelo
            // 
            this.btnConfirmarVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarVuelo.Location = new System.Drawing.Point(301, 310);
            this.btnConfirmarVuelo.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmarVuelo.Name = "btnConfirmarVuelo";
            this.btnConfirmarVuelo.Size = new System.Drawing.Size(165, 28);
            this.btnConfirmarVuelo.TabIndex = 56;
            this.btnConfirmarVuelo.Text = "Guardar Cambios";
            this.btnConfirmarVuelo.UseVisualStyleBackColor = true;
            this.btnConfirmarVuelo.Click += new System.EventHandler(this.btnConfirmarVuelo_Click_1);
            // 
            // cmbNuevoEstado
            // 
            this.cmbNuevoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNuevoEstado.FormattingEnabled = true;
            this.cmbNuevoEstado.Location = new System.Drawing.Point(127, 251);
            this.cmbNuevoEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNuevoEstado.Name = "cmbNuevoEstado";
            this.cmbNuevoEstado.Size = new System.Drawing.Size(177, 28);
            this.cmbNuevoEstado.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 256);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "Estado :";
            // 
            // formModificarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 374);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formModificarVuelo";
            this.Text = "Modificar Vuelo";
            this.Load += new System.EventHandler(this.formModificarVuelo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker NuevaFechaL;
        private System.Windows.Forms.DateTimePicker NuevaFechaS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNuevoTA;
        private System.Windows.Forms.ComboBox cmbHoraSalida;
        private System.Windows.Forms.ComboBox cmbHoraLlegada;
        private System.Windows.Forms.ComboBox cmbNuevoA;
        private System.Windows.Forms.ComboBox cmbNuevoAO;
        private System.Windows.Forms.ComboBox cmbNuevoAD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNuevoEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancelarVuelo;
        private System.Windows.Forms.Button btnConfirmarVuelo;
    }
}